namespace I.RULE_CM_Level_Creator
{
    public partial class Form1 : Form
    {
        String levelName = "Unnamed Level";
        String levelDescription = "";
        String levelNameColor = "";
        String levelDescriptionColor = "";
        float levelHeartFallSpeed = 1;
        int levelHeartValue = 50;
        float levelHeartSize = 1;
        int levelHeartTimer = 0;
        int levelStartingHearts = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "") {
                levelName = textBox1.Text;
            }
            MessageBox.Show("Level Name: " + levelName);
            MessageBox.Show("Level saved!");
            Environment.Exit(0);
        }
    }
}