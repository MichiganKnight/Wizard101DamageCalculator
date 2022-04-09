using System.Collections;
using System.Globalization;
using System.Resources;

using Wizard101DamageCalculator.Properties;

namespace Wizard101DamageCalculator.Windows
{
    public partial class EnchantmentWindow : Form
    {
        public bool StrongApplied { get; set; }
        public bool GiantApplied { get; set; }
        public bool MonstrousApplied { get; set; }
        public bool GargantuanApplied { get; set; }
        public bool ColossalApplied { get; set; }
        public bool EpicApplied { get; set; }

        private readonly Dictionary<string, Spell> SpellNamePair = new();

        private readonly string currentSpellName;

        public EnchantmentWindow(string text)
        {
            InitializeComponent();

            currentSpellName = text;
        }

        private void EnchantmentWindow_Load(object sender, EventArgs e)
        {
            Spell[] spells = Spell.GetAllSpells();

            foreach (Spell spell in spells)
            {
                SpellNamePair.Add(spell.SpellName, spell);
            }

            foreach (KeyValuePair<string, Spell> keyValuePair in SpellNamePair)
            {
                Spell currentSpell = keyValuePair.Value;

                if (keyValuePair.Key == currentSpellName)
                {
                    School school = Spell.GetCurrentSpellSchool(keyValuePair.Value);
                    string simpleSpell = keyValuePair.Key.Replace(" ", "");

                    ResourceSet? resourceSet = Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, true, true);

                    foreach (DictionaryEntry resource in resourceSet)
                    {
                        if (simpleSpell == resource.Key.ToString())
                        {
                            PictureSpell.Image = (Image?)resource.Value;

                            break;
                        }
                    }
                }
            }
        }

        private void PictureSpell_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictureStrong_Click(object sender, EventArgs e)
        {
            StrongApplied = true;

            Close();
        }

        private void PictureGiant_Click(object sender, EventArgs e)
        {
            GiantApplied = true;

            Close();
        }

        private void PictureMonstrous_Click(object sender, EventArgs e)
        {
            MonstrousApplied = true;

            Close();
        }

        private void PictureGargantuan_Click(object sender, EventArgs e)
        {
            GargantuanApplied = true;

            Close();
        }

        private void PictureColossal_Click(object sender, EventArgs e)
        {
            ColossalApplied = true;

            Close();
        }

        private void PictureEpic_Click(object sender, EventArgs e)
        {
            EpicApplied = true;

            Close();
        }
    }
}
