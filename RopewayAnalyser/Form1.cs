namespace RopewayAnalyser
{
    public partial class Form1 : Form
    {
        int stateStartfreigabe = 0;
        int stateHandnotaus = 0;
        int stateThermoschuetz = 0;
        int stateThermoumschalter = 0;


        public Form1()
        {
            InitializeComponent();
        }

        public string BoolToState(int state)
        {
            if (state == 1)
                return "Angezogen";
            else
                return "Abgefallen";
        }

        public void logHilfsschuetz(int state)
        {
            if(state != stateStartfreigabe)
            {
                LB_Hilfsschuetz.Items.Add($"{DateTime.Now.TimeOfDay}: {BoolToState(state)}");
                //stateStartfreigabe = state;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BT_Hilfsschuetz_Click(object sender, EventArgs e)
        {
            logHilfsschuetz(1);
        }
    }
}