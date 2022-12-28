namespace Assignment11_IliaBogatyrev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public class Pet
        {
            // Properties
            public string Name { get; set; }
            public string Type { get; set; }
            public int Age { get; set; }

            // Constructor
            public Pet(string name, string type, int age)
            {
                Name = name;
                Type = type;
                Age = age;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the user's input
            string name = textBox1.Text;
            string type = textBox2.Text;
            int age = Convert.ToInt32(textBox3.Text);

            // Create a Pet object
            Pet pet = new Pet(name, type, age);

            // Display the pet's information
            label4.Text = "Name: " + pet.Name;
            label5.Text = "Type: " + pet.Type;
            label6.Text = "Age: " + pet.Age;
            label7.Text = "You have created a " + pet.Type + ". Here are some details:";
        }
    }
}