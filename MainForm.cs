using System.Collections;
using System.Globalization;
using System.Resources;

using Wizard101DamageCalculator.Properties;

namespace Wizard101DamageCalculator
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<string, Spell> spellNamePair = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            spellNamePair.Clear();

            AutoCompleteStringCollection source = new();

            Spell[] spells = Spell.GetAllSpells();
            string[] spellNames = Spell.GetAllSpellNames(spells);

            foreach (Spell spell in spells)
            {
                spellNamePair.Add(spell.SpellName, spell);

                source.Add(spell.SpellName);
            }

            TextBoxChooseSpell.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TextBoxChooseSpell.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TextBoxChooseSpell.AutoCompleteCustomSource = source;
        }

        private void TextboxChooseSpell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (KeyValuePair<string, Spell> keyValuePair in spellNamePair)
                {
                    if (keyValuePair.Key == TextBoxChooseSpell.Text)
                    {
                        School school = Spell.GetCurrentSpellSchool(keyValuePair.Value);
                        string simpleSpell = keyValuePair.Key.Replace(" ", "");

                        ResourceSet? resourceSet = Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, true, true);

                        foreach (DictionaryEntry resource in resourceSet)
                        {
                            if (simpleSpell == resource.Key.ToString())
                            {
                                PictureSpell.Image = (Image?)resource.Value;
                            }
                            else
                            {
                                #region Debug Purposes Only
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                MessageBoxIcon boxIcon = MessageBoxIcon.Information;
                                DialogResult result = MessageBox.Show($"Unable To Find Picture For {simpleSpell}\nDoes It Exist?", "", buttons, boxIcon);
                                
                                if (result == DialogResult.OK)
                                {
                                    break;
                                }
                                #endregion
                            }
                        }
                    }
                }
            }
        }

        private void TextBoxBoostPlus_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TextBoxBoostPercent_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}