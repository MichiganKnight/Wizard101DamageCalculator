using System.Collections;
using System.Globalization;
using System.Resources;
using Wizard101DamageCalculator.Properties;
using Wizard101DamageCalculator.Windows;

namespace Wizard101DamageCalculator
{
    public partial class MainForm : Form
    {
        private Dictionary<string, Spell> SpellNamePair = new();

        private Spell[]? spells;

        private double PercentBoost;
        private int PlusBoost;

        public int SingleDamage;
        public int MinDamage;
        public int MaxDamage;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SpellNamePair = new Dictionary<string, Spell>();

            SpellNamePair.Clear();

            AutoCompleteStringCollection source = new();

            spells = Spell.GetAllSpells();

            foreach (Spell spell in spells)
            {
                SpellNamePair.Add(spell.SpellName, spell);

                source.Add(spell.SpellName);
            }

            TextBoxChooseSpell.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TextBoxChooseSpell.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TextBoxChooseSpell.AutoCompleteCustomSource = source;
        }

        private void TextboxChooseSpell_KeyDown(object sender, KeyEventArgs e)
        {
            string simpleSpell = "";
            Spell? currentSpell = null;

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (!string.IsNullOrEmpty(TextBoxChooseSpell.Text))
                {
                    if (IsValid(TextBoxChooseSpell.Text))
                    {
                        foreach (KeyValuePair<string, Spell> keyValuePair in SpellNamePair)
                        {
                            if (keyValuePair.Key == TextBoxChooseSpell.Text)
                            {
                                currentSpell = keyValuePair.Value;
                                School school = Spell.GetCurrentSpellSchool(keyValuePair.Value);
                                simpleSpell = keyValuePair.Key.Replace(" ", "");

                                ResourceSet? resourceSet = Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, true, true);

                                foreach (DictionaryEntry resource in resourceSet)
                                {
                                    if (simpleSpell == resource.Key.ToString())
                                    {
                                        PictureSpell.Image = (Image?)resource.Value;
                                    }
                                }

                                switch (keyValuePair.Value.Type)
                                {
                                    case Type.Single:
                                        SingleDamage = keyValuePair.Value.Damage;
                                        LabelMinimumOrSingleDamage.Text = $"Damage: {SingleDamage}";
                                        break;
                                    case Type.MinMax:
                                        MinDamage = keyValuePair.Value.MinDamage;
                                        MaxDamage = keyValuePair.Value.MaxDamage;
                                        LabelMinimumOrSingleDamage.Text = $"Minimum Damage: {MinDamage}";
                                        labelMaximumDamage.Text = $"Maximum Damage: {MaxDamage}";
                                        break;
                                    default:
                                        break;
                                }

                            }
                        }

                        EnchantmentWindow enchantmentWindow = new(TextBoxChooseSpell.Text);

                        Hide();

                        enchantmentWindow.ShowDialog();

                        Show();

                        bool strongApplied = enchantmentWindow.StrongApplied;

                        if (strongApplied)
                        {
                            PictureSpell.Image = null;

                            ResourceSet? resourceSet = Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, true, true);

                            foreach (DictionaryEntry resource in resourceSet)
                            {
                                if (simpleSpell == resource.Key.ToString())
                                {
                                    PictureSpell.Image = (Image?)resource.Value;
                                }
                            }

                            switch (currentSpell.Type)
                            {
                                case Type.Single:
                                    currentSpell.Damage = currentSpell.Damage + 100;
                                    break;
                                case Type.MinMax:
                                    currentSpell.MinDamage += 100;
                                    currentSpell.MaxDamage += 100;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Spell Does Not Exist", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (result == DialogResult.OK)
                        {
                            TextBoxChooseSpell.Focus();
                        }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("You Need To Enter A Spell Name", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    if (result == DialogResult.OK)
                    {
                        TextBoxChooseSpell.Focus();
                    }
                }
            }
        }

        private bool IsValid(string text)
        {
            bool isValid = false;

            foreach (Spell spell in spells)
            {
                if (spell.SpellName == text)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
            }

            return isValid;
        }

        private void TextBoxBoostPercent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (!string.IsNullOrEmpty(TextBoxBoostPercent.Text))
                {
                    string text = TextBoxBoostPercent.Text;

                    text = "0." + text;

                    PercentBoost = double.Parse(text);
                }

                TextBoxBoostPlus.Focus();
            }
        }

        private void TextBoxBoostPlus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (!string.IsNullOrEmpty(TextBoxBoostPlus.Text))
                {
                    string text = TextBoxBoostPlus.Text;

                    PlusBoost = int.Parse(text);
                }

                TextBoxChooseSpell.Focus();
            }
        }

        private void PictureSpell_Click(object sender, EventArgs e)
        {

        }
    }
}