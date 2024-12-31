namespace CuitValidatorApp
{
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();
        }

        // Estos son los 3 únicos CUIT Internacionales definidos por ARCA que no pasan la validación por estár mal diseñados.
        private static readonly HashSet<string> INTERNATIONAL_EXCEPTION_LIST = new HashSet<string>
        {
            "50000002882",  // ESTADO ASOCIADO DE GRANADA - PERSONA HUMANA   -> debería ser 50000002884
            "55000002884",  // ESTADO ASOCIADO DE GRANADA - PERSONA JURIDICA -> debería ser 55000002886
            "55000005069"   // SAMOA OCCIDENTAL - PERSONA JURIDICA           -> debería ser 55000005060
        };

        private void btn_Validar_Click(object sender, EventArgs e)
        {
            lst_nacional.Items.Clear();
            lst_internacional.Items.Clear();
            lst_invalid.Items.Clear();

            string[] cuits = txt_cuit.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string cuit in cuits)
            {
                string trimmedCuit = cuit.Trim();
                if (IsValidCuit(trimmedCuit))
                {
                    int prefix = int.Parse(trimmedCuit.Substring(0, 2));
                    if (prefix >= 20 && prefix < 35)
                    {
                        lst_nacional.Items.Add(trimmedCuit); // Solo Nac
                    }
                    else if (prefix >= 50 && prefix <= 55)
                    {
                        lst_internacional.Items.Add(trimmedCuit); // Solo Internac
                    }
                    else
                    {
                        lst_invalid.Items.Add(trimmedCuit); // Inválidos (prefijo fuera de rango)
                    }
                }
                else
                {
                    lst_invalid.Items.Add(trimmedCuit); // Inválidos (fallan la validación)
                }
            }
        }

        private bool IsValidCuit(string cuit)
        {
            if (string.IsNullOrEmpty(cuit) || cuit.Length != 11 || !cuit.All(char.IsDigit))
                return false;
            //if (INTERNATIONAL_EXCEPTION_LIST.Contains(cuit))
            //    return true;

            int[] weights = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            int sum = 0;

            for (int i = 0; i < weights.Length; i++)
            {
                sum += int.Parse(cuit[i].ToString()) * weights[i];
            }

            int remainder = sum % 11;
            int expectedVerifier = (remainder == 0) ? 0 : remainder == 1 ? 9 : 11 - remainder;

            int actualVerifier = int.Parse(cuit[10].ToString());
            return expectedVerifier == actualVerifier;
        }
    }
}