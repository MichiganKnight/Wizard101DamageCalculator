using System.Collections;
using System.Globalization;
using System.Resources;

using Wizard101DamageCalculator.Properties;

namespace Wizard101DamageCalculator.Windows
{
    public partial class EnchantmentWindow : Form
    {
        private readonly Dictionary<string, Spell> SpellNamePair = new();

        private Spell? currentSpell;

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
                currentSpell = keyValuePair.Value;

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
            Close();
        }

        private void PictureGiant_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictureMonstrous_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictureGargantuan_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictureColossal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictureEpic_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
