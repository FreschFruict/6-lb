using Microsoft.VisualBasic.Devices;
using System.Net;
using THI1;



public partial class Form1 : Form
{
    Flower f = new Flower();
    List<Flower> fl = new List<Flower>();

    private void showNetInfo()
    {
        Bucket flower = new Bucket(fl);
        string t = "Name\t\tcolor\tprice\r\n";

        foreach (var i in fl)
        {

            t += i.print() + "\r\n"
                //f.Color + "\t"
                //f.Cost[i].ToString() + "\t" +
                ;
        }

        t += "\r\n\r\n- - - - - - - \r\n";

        t += "Summary of the bucket: " + flower.Pric().ToString();
        textBox1.Text = t;
    }

    private void Update()
    {
        showNetInfo();
        comboBox2.Items.Clear();
        Bucket flower = new Bucket(fl);
        //comboBox2.Items.Clear();
        foreach (var i in fl)
        {
            string t = i.print();
            comboBox2.Items.Add(t);
            //comboBox2.Items.Add(t);
        }
    }
    public Form1()
    {
        InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e)
    {
        showNetInfo();
    }

    private void onChangeTab(object sender, EventArgs e)
    {
        Update();

    }

    // Buttons

    private void addAppliance_click(object sender, EventArgs e)
    {


        int PC = (int)numericUpDown1.Value;
        string p = textBox2.Text;
        string color = textBox3.Text;
        Flower tmp = new Flower();
        tmp.Name = p;
        tmp.Color = color;
        tmp.Cost = PC;
        //f.Name = p;
        //f.Color = color;
        //f.Cost = PC;
        fl.Add(tmp);

        MessageBox.Show("Flower added");
        /*switch (textBox2.)
        {
            case 0:
                List<Flower> flowerList = new List<Flower>();
                Flower tmp = new Flower();
                tmp.Color = "Green";
                tmp.Name = "Rose";
                tmp.Type = "Rose";
                tmp.Cost = 600;
                Flower tmp1 = new Flower();
                tmp1.Color = "Red";
                tmp1.Name = "Cactus";
                tmp1.Type = "Fern";
                tmp1.Cost = 500;

                flowerList.Add(tmp);

                flowerList.Add(tmp1);
                int p = 0;

                Bucket flower = new Bucket(flowerList);
                f.AddFlower(FactoryElectricalAppliance.CreateLamp());
                MessageBox.Show("Appliance added!");
                break;
            case 1:
                network.AddApplicance(FactoryElectricalAppliance.CreateKettle(PC));
                MessageBox.Show("Appliance added!");
                break;
            case 2:
                f.Add(FactoryElectricalAppliance.CreateHeater(PC));
                MessageBox.Show("Appliance added!");
                break;
            case 3:
                network.AddApplicance(FactoryElectricalAppliance.CreateChandelier());
                MessageBox.Show("Appliance added!");
                break;
            case 4:
                network.AddApplicance(FactoryElectricalAppliance.CreateVacuumCleaner(Color.AliceBlue, PC));
                MessageBox.Show("Appliance added!");
                break;
        }*/

        Update();


    }

    private void removeAppliance_click(object sender, EventArgs e)
    {
        int index = comboBox2.SelectedIndex;

        fl.RemoveAt(index);

        MessageBox.Show("Appliance removed!");

        Update();
    }

    /*
    List<Flower> flowerList = new List<Flower>();
        Flower tmp = new Flower();
        tmp.Color = "Green";
        tmp.Name = "Rose";
        tmp.Type = "Rose";
        tmp.Cost = 600;
        Flower tmp1 = new Flower();
        tmp1.Color = "Red";
        tmp1.Name = "Cactus";
        tmp1.Type = "Fern";
        tmp1.Cost = 500;

        flowerList.Add(tmp);

        flowerList.Add(tmp1);
        int p = 0;

        Bucket flower = new Bucket(flowerList);
        */
    private void InitializeComponent()
    {
        textBox1 = new TextBox();
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        tabPage2 = new TabPage();
        label4 = new Label();
        textBox3 = new TextBox();
        textBox2 = new TextBox();
        button1 = new Button();
        numericUpDown1 = new NumericUpDown();
        label2 = new Label();
        label1 = new Label();
        tabPage3 = new TabPage();
        button2 = new Button();
        comboBox2 = new ComboBox();
        label3 = new Label();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        tabPage2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        tabPage3.SuspendLayout();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.AcceptsTab = true;
        textBox1.AllowDrop = true;
        textBox1.BackColor = SystemColors.ButtonShadow;
        textBox1.BorderStyle = BorderStyle.None;
        textBox1.Dock = DockStyle.Fill;
        textBox1.Location = new Point(3, 3);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(599, 338);
        textBox1.TabIndex = 0;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Controls.Add(tabPage3);
        tabControl1.Location = new Point(26, 12);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(613, 377);
        tabControl1.TabIndex = 0;
        tabControl1.Click += onChangeTab;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(textBox1);
        tabPage1.Location = new Point(4, 29);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(605, 344);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Main";
        tabPage1.UseVisualStyleBackColor = true;
        tabPage1.Click += tabPage1_Click;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(label4);
        tabPage2.Controls.Add(textBox3);
        tabPage2.Controls.Add(textBox2);
        tabPage2.Controls.Add(button1);
        tabPage2.Controls.Add(numericUpDown1);
        tabPage2.Controls.Add(label2);
        tabPage2.Controls.Add(label1);
        tabPage2.Location = new Point(4, 29);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(605, 344);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Add";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(16, 119);
        label4.Name = "label4";
        label4.Size = new Size(156, 20);
        label4.TabIndex = 7;
        label4.Text = "Впишите цвет цветка";
        label4.Click += label4_Click;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(16, 163);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(524, 27);
        textBox3.TabIndex = 6;
        textBox3.TextChanged += textBox3_TextChanged;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(16, 62);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(524, 27);
        textBox2.TabIndex = 5;
        // 
        // button1
        // 
        button1.Location = new Point(16, 305);
        button1.Name = "button1";
        button1.Size = new Size(67, 33);
        button1.TabIndex = 4;
        button1.Text = "Add";
        button1.UseVisualStyleBackColor = true;
        button1.Click += addAppliance_click;
        // 
        // numericUpDown1
        // 
        numericUpDown1.Location = new Point(16, 252);
        numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(103, 27);
        numericUpDown1.TabIndex = 3;
        numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(16, 207);
        label2.Name = "label2";
        label2.Size = new Size(165, 20);
        label2.TabIndex = 1;
        label2.Text = "Запишите цену цветка";
        label2.Click += label2_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(16, 15);
        label1.Name = "label1";
        label1.Size = new Size(122, 20);
        label1.TabIndex = 0;
        label1.Text = "Впишите цветок";
        // 
        // tabPage3
        // 
        tabPage3.Controls.Add(button2);
        tabPage3.Controls.Add(comboBox2);
        tabPage3.Controls.Add(label3);
        tabPage3.Location = new Point(4, 29);
        tabPage3.Name = "tabPage3";
        tabPage3.Padding = new Padding(3);
        tabPage3.Size = new Size(605, 344);
        tabPage3.TabIndex = 2;
        tabPage3.Text = "Remove";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new Point(23, 253);
        button2.Name = "button2";
        button2.Size = new Size(94, 29);
        button2.TabIndex = 2;
        button2.Text = "Remove";
        button2.UseVisualStyleBackColor = true;
        button2.Click += removeAppliance_click;
        // 
        // comboBox2
        // 
        comboBox2.FormattingEnabled = true;
        comboBox2.Location = new Point(23, 107);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new Size(258, 28);
        comboBox2.TabIndex = 1;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(23, 28);
        label3.Name = "label3";
        label3.Size = new Size(365, 20);
        label3.TabIndex = 0;
        label3.Text = "Выберите цветок, который хотите убрать из букета";
        label3.Click += label3_Click;
        // 
        // Form1
        // 
        ClientSize = new Size(706, 466);
        Controls.Add(tabControl1);
        Name = "Form1";
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        tabPage2.ResumeLayout(false);
        tabPage2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        tabPage3.ResumeLayout(false);
        tabPage3.PerformLayout();
        ResumeLayout(false);
    }

    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TabPage tabPage3;

    private void tabPage1_Click(object sender, EventArgs e)
    {
        Update();
    }

    private TextBox textBox1;
    private Label label2;
    private Label label1;

    private Button button1;
    private NumericUpDown numericUpDown1;

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {

    }

    private Button button2;
    private Label label3;
    private TextBox textBox2;

    private ComboBox comboBox2;

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private TextBox textBox3;

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private Label label4;

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }
}

