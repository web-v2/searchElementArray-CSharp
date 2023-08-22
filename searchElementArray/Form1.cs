namespace searchElementArray
{
    public partial class Form1 : Form
    {
        private String[] cursos = { "HTML", "CSS", "Javascript", "Nodejs", "C#", "Go", "Java", "Vue" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creamos una nueva variable la cual pasamos el valor de la caja de texto a Mayuscula.
            String n = textBox1.Text;
            String nm = n.ToUpper();


            bool encuentra = false;
            for (int i = 0; i < cursos.Length && encuentra==false; i++)
            {
                //Creamos un nuevo array al que le pasamos todos los valores a Mayuscula.
                String[] cv = new String[cursos.Length];
                cv[i] = cursos[i].ToUpper();

                if (nm.Equals(cv[i]))
                {
                    encuentra = true;
                }
            }
            if (encuentra) {
                MessageBox.Show("Valor encontrado en el Array");
            }
            else
            {
                MessageBox.Show("Valor no existe en el Array");
            }

            textBox1.ResetText();
        }
    }
}