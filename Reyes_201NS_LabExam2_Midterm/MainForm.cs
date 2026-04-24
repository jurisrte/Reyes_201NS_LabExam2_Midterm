using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reyes_201NS_LabExam1_Midterm
{
    public partial class MainForm : Form
    {
        private int childFormCounter = 1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenChildFormMenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedMenu = sender as ToolStripMenuItem;
            if (clickedMenu == null)
            {
                return;
            }

            if (clickedMenu == fourJeePOSIncToolStripMenuItem || clickedMenu == simplePOSToolStripMenuItem)
            {
                SimplePOSForm simplePos = new SimplePOSForm();
                simplePos.MdiParent = this;
                simplePos.Text = clickedMenu.Text;
                simplePos.Show();
                return;
            }

            if (clickedMenu == fourJeePOSOrderingToolStripMenuItem)
            {
                OrderingPOSForm orderingPos = new OrderingPOSForm();
                orderingPos.MdiParent = this;
                orderingPos.Text = clickedMenu.Text;
                orderingPos.Show();
                return;
            }

            OpenModuleForm(clickedMenu.Text);
        }

        private void OpenModuleForm(string formTitle)
        {
            Form child = new Form();
            child.MdiParent = this;
            child.Text = formTitle + " " + childFormCounter;
            child.StartPosition = FormStartPosition.Manual;
            child.Size = new Size(560, 360);

            Label titleLabel = new Label();
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Text = formTitle;

            child.Controls.Add(titleLabel);
            childFormCounter++;
            child.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class SimplePOSForm : Form
    {
        private readonly TextBox itemnameTxtbox;
        private readonly TextBox priceTxtbox;
        private readonly TextBox qtyTxtbox;
        private readonly TextBox discountTxtbox;
        private readonly TextBox discountedTxtbox;
        private readonly TextBox amountPaidTxtbox;
        private readonly TextBox cashGivenTxtbox;
        private readonly TextBox changeTxtbox;
        private readonly FlowLayoutPanel imagePanel;
        private readonly RadioButton radioButton1;
        private readonly RadioButton regularRbtn;
        private readonly RadioButton EmployeeRdbtn;
        private readonly RadioButton noTaxRdbtn;
        private readonly string[] itemNames = new string[]
        {
            "Combo Meal A", "Combo Meal B", "Combo Meal C", "Combo Meal D", "Combo Meal E",
            "Combo Meal F", "Combo Meal G", "Combo Meal H", "Combo Meal I", "Combo Meal J",
            "Combo Meal K", "Combo Meal L", "Combo Meal M", "Combo Meal N", "Combo Meal O",
            "Combo Meal P", "Combo Meal Q", "Combo Meal R", "Combo Meal S", "Combo Meal T"
        };
        private int qty;
        private double price;
        private double discount_amt;
        private double discounted_amt;

        public SimplePOSForm()
        {
            Text = "Simple POS";
            ClientSize = new Size(980, 560);
            StartPosition = FormStartPosition.CenterParent;

            imagePanel = new FlowLayoutPanel();
            imagePanel.Dock = DockStyle.Top;
            imagePanel.Height = 420;
            imagePanel.WrapContents = true;
            imagePanel.AutoScroll = true;
            imagePanel.Padding = new Padding(10);

            CreatePictureBoxes();

            Panel bottomPanel = new Panel();
            bottomPanel.Dock = DockStyle.Fill;
            bottomPanel.Padding = new Padding(10);

            Label itemLabel = new Label();
            itemLabel.Text = "Item Name:";
            itemLabel.Location = new Point(10, 15);
            itemLabel.AutoSize = true;

            itemnameTxtbox = new TextBox();
            itemnameTxtbox.Location = new Point(80, 12);
            itemnameTxtbox.Width = 170;

            Label priceLabel = new Label();
            priceLabel.Text = "Price:";
            priceLabel.Location = new Point(270, 15);
            priceLabel.AutoSize = true;

            priceTxtbox = new TextBox();
            priceTxtbox.Location = new Point(315, 12);
            priceTxtbox.Width = 120;

            Label qtyLabel = new Label();
            qtyLabel.Text = "Quantity:";
            qtyLabel.Location = new Point(455, 15);
            qtyLabel.AutoSize = true;

            qtyTxtbox = new TextBox();
            qtyTxtbox.Location = new Point(515, 12);
            qtyTxtbox.Width = 120;

            Label discountLabel = new Label();
            discountLabel.Text = "Discount:";
            discountLabel.Location = new Point(650, 15);
            discountLabel.AutoSize = true;

            discountTxtbox = new TextBox();
            discountTxtbox.Location = new Point(710, 12);
            discountTxtbox.Width = 120;
            discountTxtbox.ReadOnly = true;

            Label amountPaidLabel = new Label();
            amountPaidLabel.Text = "Amount Paid:";
            amountPaidLabel.Location = new Point(10, 52);
            amountPaidLabel.AutoSize = true;

            amountPaidTxtbox = new TextBox();
            amountPaidTxtbox.Location = new Point(90, 49);
            amountPaidTxtbox.Width = 120;
            amountPaidTxtbox.ReadOnly = true;

            Label cashGivenLabel = new Label();
            cashGivenLabel.Text = "Cash Given:";
            cashGivenLabel.Location = new Point(230, 52);
            cashGivenLabel.AutoSize = true;

            cashGivenTxtbox = new TextBox();
            cashGivenTxtbox.Location = new Point(305, 49);
            cashGivenTxtbox.Width = 120;

            Label discountedLabel = new Label();
            discountedLabel.Text = "Discounted Amt:";
            discountedLabel.Location = new Point(445, 52);
            discountedLabel.AutoSize = true;

            discountedTxtbox = new TextBox();
            discountedTxtbox.Location = new Point(545, 49);
            discountedTxtbox.Width = 120;
            discountedTxtbox.ReadOnly = true;

            Label changeLabel = new Label();
            changeLabel.Text = "Change:";
            changeLabel.Location = new Point(685, 52);
            changeLabel.AutoSize = true;

            changeTxtbox = new TextBox();
            changeTxtbox.Location = new Point(740, 49);
            changeTxtbox.Width = 90;
            changeTxtbox.ReadOnly = true;

            radioButton1 = new RadioButton();
            radioButton1.Text = "Senior Citizen";
            radioButton1.Location = new Point(10, 85);
            radioButton1.AutoSize = true;
            radioButton1.Click += radioButton1_Click;

            regularRbtn = new RadioButton();
            regularRbtn.Text = "With Disc. Card";
            regularRbtn.Location = new Point(130, 85);
            regularRbtn.AutoSize = true;
            regularRbtn.Click += regularRbtn_Click;

            EmployeeRdbtn = new RadioButton();
            EmployeeRdbtn.Text = "Employee Disc.";
            EmployeeRdbtn.Location = new Point(260, 85);
            EmployeeRdbtn.AutoSize = true;
            EmployeeRdbtn.Click += EmployeeRdbtn_Click;

            noTaxRdbtn = new RadioButton();
            noTaxRdbtn.Text = "No Discount";
            noTaxRdbtn.Location = new Point(390, 85);
            noTaxRdbtn.AutoSize = true;
            noTaxRdbtn.Click += noTaxRdbtn_Click;

            Button calculateBtn = new Button();
            calculateBtn.Text = "Calculate";
            calculateBtn.Location = new Point(650, 80);
            calculateBtn.Size = new Size(90, 28);
            calculateBtn.Click += calculateBtn_Click;

            Button newBtn = new Button();
            newBtn.Text = "New";
            newBtn.Location = new Point(745, 80);
            newBtn.Size = new Size(90, 28);
            newBtn.Click += newBtn_Click;

            Button exitBtn = new Button();
            exitBtn.Text = "Exit";
            exitBtn.Location = new Point(840, 80);
            exitBtn.Size = new Size(90, 28);
            exitBtn.Click += exitBtn_Click;

            bottomPanel.Controls.Add(itemLabel);
            bottomPanel.Controls.Add(itemnameTxtbox);
            bottomPanel.Controls.Add(priceLabel);
            bottomPanel.Controls.Add(priceTxtbox);
            bottomPanel.Controls.Add(qtyLabel);
            bottomPanel.Controls.Add(qtyTxtbox);
            bottomPanel.Controls.Add(discountLabel);
            bottomPanel.Controls.Add(discountTxtbox);
            bottomPanel.Controls.Add(amountPaidLabel);
            bottomPanel.Controls.Add(amountPaidTxtbox);
            bottomPanel.Controls.Add(cashGivenLabel);
            bottomPanel.Controls.Add(cashGivenTxtbox);
            bottomPanel.Controls.Add(discountedLabel);
            bottomPanel.Controls.Add(discountedTxtbox);
            bottomPanel.Controls.Add(changeLabel);
            bottomPanel.Controls.Add(changeTxtbox);
            bottomPanel.Controls.Add(radioButton1);
            bottomPanel.Controls.Add(regularRbtn);
            bottomPanel.Controls.Add(EmployeeRdbtn);
            bottomPanel.Controls.Add(noTaxRdbtn);
            bottomPanel.Controls.Add(calculateBtn);
            bottomPanel.Controls.Add(newBtn);
            bottomPanel.Controls.Add(exitBtn);

            Controls.Add(bottomPanel);
            Controls.Add(imagePanel);
        }

        private void CreatePictureBoxes()
        {
            for (int i = 1; i <= 20; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = "pictureBox" + i;
                pictureBox.Size = new Size(170, 90);
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox.BackColor = Color.WhiteSmoke;
                pictureBox.Cursor = Cursors.Hand;

                Label title = new Label();
                title.Dock = DockStyle.Bottom;
                title.Height = 20;
                title.TextAlign = ContentAlignment.MiddleCenter;
                title.Text = itemNames[i - 1];
                title.BackColor = Color.Gainsboro;

                Panel host = new Panel();
                host.Width = 180;
                host.Height = 120;
                host.Margin = new Padding(5);
                host.Controls.Add(title);
                host.Controls.Add(pictureBox);

                pictureBox.Dock = DockStyle.Fill;

                switch (i)
                {
                    case 1: pictureBox.Click += pictureBox1_Click; break;
                    case 2: pictureBox.Click += pictureBox2_Click; break;
                    case 3: pictureBox.Click += pictureBox3_Click; break;
                    case 4: pictureBox.Click += pictureBox4_Click; break;
                    case 5: pictureBox.Click += pictureBox5_Click; break;
                    case 6: pictureBox.Click += pictureBox6_Click; break;
                    case 7: pictureBox.Click += pictureBox7_Click; break;
                    case 8: pictureBox.Click += pictureBox8_Click; break;
                    case 9: pictureBox.Click += pictureBox9_Click; break;
                    case 10: pictureBox.Click += pictureBox10_Click; break;
                    case 11: pictureBox.Click += pictureBox11_Click; break;
                    case 12: pictureBox.Click += pictureBox12_Click; break;
                    case 13: pictureBox.Click += pictureBox13_Click; break;
                    case 14: pictureBox.Click += pictureBox14_Click; break;
                    case 15: pictureBox.Click += pictureBox15_Click; break;
                    case 16: pictureBox.Click += pictureBox16_Click; break;
                    case 17: pictureBox.Click += pictureBox17_Click; break;
                    case 18: pictureBox.Click += pictureBox18_Click; break;
                    case 19: pictureBox.Click += pictureBox19_Click; break;
                    case 20: pictureBox.Click += pictureBox20_Click; break;
                }

                imagePanel.Controls.Add(host);
            }
        }

        public void price_item_TextValue(string itemname, string price)
        {
            itemnameTxtbox.Text = itemname;
            priceTxtbox.Text = price;
        }

        private void quantityTxtbox()
        {
            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void quantity_price_Convert()
        {
            qty = Convert.ToInt32(qtyTxtbox.Text);
            price = Convert.ToDouble(priceTxtbox.Text);
        }

        private void computation_Formula_and_DisplayData()
        {
            discounted_amt = (qty * price) - discount_amt;
            discountTxtbox.Text = discount_amt.ToString("n");
            discountedTxtbox.Text = discounted_amt.ToString("n");
            amountPaidTxtbox.Text = discounted_amt.ToString("n");
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double cashGiven;

            if (!double.TryParse(cashGivenTxtbox.Text, out cashGiven))
            {
                MessageBox.Show("Invalid cash given.", "Simple POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (radioButton1.Checked)
            {
                radioButton1_Click(sender, e);
            }
            else if (regularRbtn.Checked)
            {
                regularRbtn_Click(sender, e);
            }
            else if (EmployeeRdbtn.Checked)
            {
                EmployeeRdbtn_Click(sender, e);
            }
            else
            {
                noTaxRdbtn_Click(sender, e);
            }

            changeTxtbox.Text = (cashGiven - discounted_amt).ToString("n");
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.30;
                computation_Formula_and_DisplayData();
                regularRbtn.Checked = false;
                EmployeeRdbtn.Checked = false;
                noTaxRdbtn.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantityTxtbox();
            }
        }

        private void regularRbtn_Click(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.30;
                computation_Formula_and_DisplayData();
                radioButton1.Checked = false;
                EmployeeRdbtn.Checked = false;
                noTaxRdbtn.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantityTxtbox();
            }
        }

        private void EmployeeRdbtn_Click(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.15;
                computation_Formula_and_DisplayData();
                radioButton1.Checked = false;
                regularRbtn.Checked = false;
                noTaxRdbtn.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data input in quantity");
                quantityTxtbox();
            }
        }

        private void noTaxRdbtn_Click(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                discount_amt = 0;
                computation_Formula_and_DisplayData();
                radioButton1.Checked = false;
                regularRbtn.Checked = false;
                EmployeeRdbtn.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data input in quantity");
                quantityTxtbox();
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Clear();
            priceTxtbox.Clear();
            qtyTxtbox.Clear();
            discountTxtbox.Clear();
            discountedTxtbox.Clear();
            amountPaidTxtbox.Clear();
            cashGivenTxtbox.Clear();
            changeTxtbox.Clear();
            radioButton1.Checked = false;
            regularRbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;
            itemnameTxtbox.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e) { price_item_TextValue("Combo Meal A", "89.50"); quantityTxtbox(); }
        private void pictureBox2_Click(object sender, EventArgs e) { price_item_TextValue(itemNames[1], "101.50"); quantityTxtbox(); }
        private void pictureBox3_Click(object sender, EventArgs e) { price_item_TextValue(itemNames[2], "100.50"); quantityTxtbox(); }
        private void pictureBox4_Click(object sender, EventArgs e) { price_item_TextValue(itemNames[3], "111.50"); quantityTxtbox(); }
        private void pictureBox5_Click(object sender, EventArgs e) { price_item_TextValue(itemNames[4], "120.50"); quantityTxtbox(); }
        private void pictureBox6_Click(object sender, EventArgs e) { price_item_TextValue(itemNames[5], "90.50"); quantityTxtbox(); }
        private void pictureBox7_Click(object sender, EventArgs e) { price_item_TextValue(itemNames[6], "101.50"); quantityTxtbox(); }
        private void pictureBox8_Click(object sender, EventArgs e) { price_item_TextValue(itemNames[7], "123.50"); quantityTxtbox(); }
        private void pictureBox9_Click(object sender, EventArgs e) { price_item_TextValue(itemNames[8], "188.00"); quantityTxtbox(); }
        private void pictureBox10_Click(object sender, EventArgs e) { price_item_TextValue(itemNames[9], "680.50"); quantityTxtbox(); }
        private void pictureBox11_Click(object sender, EventArgs e) { price_item_TextValue(itemNames[10], "199.50"); quantityTxtbox(); }
        private void pictureBox12_Click(object sender, EventArgs e) { price_item_TextValue(itemNames[11], "99.00"); quantityTxtbox(); }
        private void pictureBox13_Click(object sender, EventArgs e) { price_item_TextValue(itemNames[12], "190.50"); quantityTxtbox(); }
        private void pictureBox14_Click(object sender, EventArgs e) { price_item_TextValue(itemNames[13], "121.50"); quantityTxtbox(); }
        private void pictureBox15_Click(object sender, EventArgs e) { price_item_TextValue(itemNames[14], "599.50"); quantityTxtbox(); }
        private void pictureBox16_Click(object sender, EventArgs e) { price_item_TextValue(itemNames[15], "91.50"); quantityTxtbox(); }
        private void pictureBox17_Click(object sender, EventArgs e) { price_item_TextValue(itemNames[16], "81.50"); quantityTxtbox(); }
        private void pictureBox18_Click(object sender, EventArgs e) { price_item_TextValue(itemNames[17], "71.50"); quantityTxtbox(); }
        private void pictureBox19_Click(object sender, EventArgs e) { price_item_TextValue(itemNames[18], "211.50"); quantityTxtbox(); }
        private void pictureBox20_Click(object sender, EventArgs e) { price_item_TextValue(itemNames[19], "576.00"); quantityTxtbox(); }
    }

    public class OrderingPOSForm : Form
    {
        private readonly TextBox discountAmountTxtbox;
        private readonly TextBox priceTxtBox;
        private readonly TextBox qtyTxtbox;
        private readonly TextBox totalBillTxtbox;
        private readonly TextBox cashGivenTxtbox;
        private readonly TextBox changeTxtbox;
        private readonly ListBox displayListbox;
        private readonly FlowLayoutPanel itemsPanel;
        private readonly RadioButton foodBundleARbtn;
        private readonly RadioButton foodBundleBRbtn;
        private readonly List<CheckBox> orderCheckBoxes = new List<CheckBox>();
        private bool isApplyingBundle;

        public OrderingPOSForm()
        {
            Text = "4JEE FOOD ORDERING APPLICATION";
            ClientSize = new Size(1000, 620);
            StartPosition = FormStartPosition.CenterParent;

            Panel leftPanel = new Panel();
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Width = 300;
            leftPanel.Padding = new Padding(10);

            Label discountLabel = new Label();
            discountLabel.Text = "Discount Amount:";
            discountLabel.Location = new Point(10, 20);
            discountLabel.AutoSize = true;

            Label foodChoicesLabel = new Label();
            foodChoicesLabel.Text = "Food Order Choices:";
            foodChoicesLabel.Location = new Point(10, 0);
            foodChoicesLabel.AutoSize = true;

            discountAmountTxtbox = new TextBox();
            discountAmountTxtbox.Location = new Point(120, 17);
            discountAmountTxtbox.Width = 150;

            Label priceLabel = new Label();
            priceLabel.Text = "Price:";
            priceLabel.Location = new Point(10, 50);
            priceLabel.AutoSize = true;

            priceTxtBox = new TextBox();
            priceTxtBox.Location = new Point(120, 47);
            priceTxtBox.Width = 150;

            Label qtyLabel = new Label();
            qtyLabel.Text = "Quantity:";
            qtyLabel.Location = new Point(10, 80);
            qtyLabel.AutoSize = true;

            qtyTxtbox = new TextBox();
            qtyTxtbox.Location = new Point(120, 77);
            qtyTxtbox.Width = 150;

            foodBundleARbtn = new RadioButton();
            foodBundleARbtn.Text = "Food Bundle A";
            foodBundleARbtn.Location = new Point(10, 107);
            foodBundleARbtn.AutoSize = true;
            foodBundleARbtn.CheckedChanged += foodBundleARbtn_CheckedChanged;

            foodBundleBRbtn = new RadioButton();
            foodBundleBRbtn.Text = "Food Bundle B";
            foodBundleBRbtn.Location = new Point(140, 107);
            foodBundleBRbtn.AutoSize = true;
            foodBundleBRbtn.CheckedChanged += foodBundleBRbtn_CheckedChanged;

            Label totalLabel = new Label();
            totalLabel.Text = "Total Bill:";
            totalLabel.Location = new Point(10, 135);
            totalLabel.AutoSize = true;

            totalBillTxtbox = new TextBox();
            totalBillTxtbox.Location = new Point(120, 132);
            totalBillTxtbox.Width = 150;
            totalBillTxtbox.ReadOnly = true;

            Label cashLabel = new Label();
            cashLabel.Text = "Cash Given:";
            cashLabel.Location = new Point(10, 165);
            cashLabel.AutoSize = true;

            cashGivenTxtbox = new TextBox();
            cashGivenTxtbox.Location = new Point(120, 162);
            cashGivenTxtbox.Width = 150;

            Label changeLabel = new Label();
            changeLabel.Text = "Change:";
            changeLabel.Location = new Point(10, 195);
            changeLabel.AutoSize = true;

            changeTxtbox = new TextBox();
            changeTxtbox.Location = new Point(120, 192);
            changeTxtbox.Width = 150;
            changeTxtbox.ReadOnly = true;

            Button calculateBtn = new Button();
            calculateBtn.Text = "Calculate Bill";
            calculateBtn.Location = new Point(10, 225);
            calculateBtn.Size = new Size(125, 30);
            calculateBtn.Click += calculateBtn_Click;

            Button printBtn = new Button();
            printBtn.Text = "Print Receipt";
            printBtn.Location = new Point(145, 225);
            printBtn.Size = new Size(125, 30);
            printBtn.Click += printBtn_Click;

            Button newBtn = new Button();
            newBtn.Text = "New";
            newBtn.Location = new Point(145, 260);
            newBtn.Size = new Size(60, 30);
            newBtn.Click += newBtn_Click;

            Button exitBtn = new Button();
            exitBtn.Text = "Exit";
            exitBtn.Location = new Point(210, 260);
            exitBtn.Size = new Size(60, 30);
            exitBtn.Click += exitBtn_Click;

            displayListbox = new ListBox();
            displayListbox.Location = new Point(10, 300);
            displayListbox.Size = new Size(260, 270);

            leftPanel.Controls.Add(foodChoicesLabel);
            leftPanel.Controls.Add(discountLabel);
            leftPanel.Controls.Add(discountAmountTxtbox);
            leftPanel.Controls.Add(priceLabel);
            leftPanel.Controls.Add(priceTxtBox);
            leftPanel.Controls.Add(qtyLabel);
            leftPanel.Controls.Add(qtyTxtbox);
            leftPanel.Controls.Add(foodBundleARbtn);
            leftPanel.Controls.Add(foodBundleBRbtn);
            leftPanel.Controls.Add(totalLabel);
            leftPanel.Controls.Add(totalBillTxtbox);
            leftPanel.Controls.Add(cashLabel);
            leftPanel.Controls.Add(cashGivenTxtbox);
            leftPanel.Controls.Add(changeLabel);
            leftPanel.Controls.Add(changeTxtbox);
            leftPanel.Controls.Add(calculateBtn);
            leftPanel.Controls.Add(printBtn);
            leftPanel.Controls.Add(newBtn);
            leftPanel.Controls.Add(exitBtn);
            leftPanel.Controls.Add(displayListbox);

            itemsPanel = new FlowLayoutPanel();
            itemsPanel.Dock = DockStyle.Fill;
            itemsPanel.Padding = new Padding(10);
            itemsPanel.AutoScroll = true;
            itemsPanel.WrapContents = true;

            CreateOrderingItems();

            Controls.Add(itemsPanel);
            Controls.Add(leftPanel);
        }

        private void CreateOrderingItems()
        {
            string[] names =
            {
                "Hawaiian", "New York Style", "Pepperoni", "Cauliflower Crust", "Deluxe",
                "Pizza Special A", "Pizza Special B", "Pizza Special C", "Pizza Special D", "Pizza Refresher",
                "Pizza 1", "Pizza 2", "Pizza 3", "Pizza 4", "Pizza 5",
                "Pizza 6", "Pizza 7", "Pizza 8", "Pizza 9", "Amazon Pizza"
            };

            for (int i = 1; i <= 20; i++)
            {
                Panel host = new Panel();
                host.Width = 150;
                host.Height = 130;
                host.Margin = new Padding(6);

                PictureBox picture = new PictureBox();
                picture.Dock = DockStyle.Top;
                picture.Height = 90;
                picture.BorderStyle = BorderStyle.FixedSingle;
                picture.BackColor = Color.WhiteSmoke;
                picture.SizeMode = PictureBoxSizeMode.CenterImage;

                CheckBox check = new CheckBox();
                check.Text = names[i - 1];
                check.AutoSize = true;
                check.Location = new Point(6, 98);
                check.Tag = GetPriceByIndex(i);
                check.CheckedChanged += orderItem_CheckedChanged;
                orderCheckBoxes.Add(check);

                switch (i)
                {
                    case 1: check.Click += checkBox1_Click; break;
                    case 2: check.Click += checkBox2_Click; break;
                    case 3: check.Click += checkBox3_Click; break;
                    case 4: check.Click += checkBox4_Click; break;
                    case 5: check.Click += checkBox5_Click; break;
                    case 6: check.Click += checkBox6_Click; break;
                    case 7: check.Click += checkBox7_Click; break;
                    case 8: check.Click += checkBox8_Click; break;
                    case 9: check.Click += checkBox9_Click; break;
                    case 10: check.Click += checkBox10_Click; break;
                    case 11: check.Click += checkBox11_Click; break;
                    case 12: check.Click += checkBox12_Click; break;
                    case 13: check.Click += checkBox13_Click; break;
                    case 14: check.Click += checkBox14_Click; break;
                    case 15: check.Click += checkBox15_Click; break;
                    case 16: check.Click += checkBox16_Click; break;
                    case 17: check.Click += checkBox17_Click; break;
                    case 18: check.Click += checkBox18_Click; break;
                    case 19: check.Click += checkBox19_Click; break;
                    case 20: check.Click += checkBox20_Click; break;
                }

                host.Controls.Add(check);
                host.Controls.Add(picture);
                itemsPanel.Controls.Add(host);
            }
        }

        private string GetPriceByIndex(int index)
        {
            switch (index)
            {
                case 1: return "500.99";
                case 2: return "550.00";
                case 3: return "608.99";
                case 4: return "700.58";
                case 5: return "500.00";
                case 6: return "750.00";
                case 7: return "700.00";
                case 8: return "850.00";
                case 9: return "450.00";
                case 10: return "650.00";
                default: return "575.00";
            }
        }

        private void item_priceValue(string discount, string price)
        {
            discountAmountTxtbox.Text = discount;
            priceTxtBox.Text = price;
        }

        private void quantityTxtbox()
        {
            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void orderItem_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            if (check == null)
            {
                return;
            }

            string itemLine = check.Text + " - " + check.Tag;
            if (check.Checked)
            {
                if (!displayListbox.Items.Contains(itemLine))
                {
                    displayListbox.Items.Add(itemLine);
                }
            }
            else
            {
                displayListbox.Items.Remove(itemLine);
            }

            if (!isApplyingBundle && check.Checked)
            {
                foodBundleARbtn.Checked = false;
                foodBundleBRbtn.Checked = false;
            }
        }

        private void ApplyFoodBundleSelection(int startIndex, int endIndex)
        {
            isApplyingBundle = true;
            for (int i = 0; i < orderCheckBoxes.Count; i++)
            {
                int oneBasedIndex = i + 1;
                orderCheckBoxes[i].Checked = oneBasedIndex >= startIndex && oneBasedIndex <= endIndex;
            }
            isApplyingBundle = false;
        }

        private void foodBundleARbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (foodBundleARbtn.Checked)
            {
                ApplyFoodBundleSelection(1, 10);
            }
        }

        private void foodBundleBRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (foodBundleBRbtn.Checked)
            {
                ApplyFoodBundleSelection(11, 20);
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            ReceiptForm receiptForm = new ReceiptForm(BuildReceiptText());
            receiptForm.ShowDialog(this);
        }

        private string BuildReceiptText()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("4JEE ORDERING APPLICATION");
            sb.AppendLine("-------------------------");
            for (int i = 0; i < displayListbox.Items.Count; i++)
            {
                sb.AppendLine(displayListbox.Items[i].ToString());
            }
            sb.AppendLine("-------------------------");
            sb.AppendLine("Discount: " + discountAmountTxtbox.Text);
            sb.AppendLine("Total Bill: " + totalBillTxtbox.Text);
            sb.AppendLine("Cash Given: " + cashGivenTxtbox.Text);
            sb.AppendLine("Change: " + changeTxtbox.Text);
            return sb.ToString();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int qty;
            double discount;
            double cash;
            double baseAmount = GetSelectedItemsTotal();

            if (baseAmount <= 0 && !double.TryParse(priceTxtBox.Text, out baseAmount))
            {
                MessageBox.Show("Invalid price.");
                quantityTxtbox();
                return;
            }

            if (!int.TryParse(qtyTxtbox.Text, out qty) || qty <= 0)
            {
                qty = 1;
            }

            if (!double.TryParse(discountAmountTxtbox.Text, out discount))
            {
                discount = 0;
            }

            double total = (baseAmount * qty) - discount;
            totalBillTxtbox.Text = total.ToString("n");

            if (double.TryParse(cashGivenTxtbox.Text, out cash))
            {
                changeTxtbox.Text = (cash - total).ToString("n");
            }
        }

        private double GetSelectedItemsTotal()
        {
            double total = 0;

            for (int i = 0; i < orderCheckBoxes.Count; i++)
            {
                if (!orderCheckBoxes[i].Checked)
                {
                    continue;
                }

                double price;
                if (orderCheckBoxes[i].Tag != null && double.TryParse(orderCheckBoxes[i].Tag.ToString(), out price))
                {
                    total += price;
                }
            }

            return total;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            discountAmountTxtbox.Clear();
            priceTxtBox.Clear();
            qtyTxtbox.Clear();
            totalBillTxtbox.Clear();
            cashGivenTxtbox.Clear();
            changeTxtbox.Clear();
            displayListbox.Items.Clear();
            isApplyingBundle = true;
            for (int i = 0; i < orderCheckBoxes.Count; i++)
            {
                orderCheckBoxes[i].Checked = false;
            }
            isApplyingBundle = false;
            foodBundleARbtn.Checked = false;
            foodBundleBRbtn.Checked = false;
            discountAmountTxtbox.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_Click(object sender, EventArgs e) { item_priceValue("0.00", "500.99"); quantityTxtbox(); }
        private void checkBox2_Click(object sender, EventArgs e) { item_priceValue("0.00", "550.00"); quantityTxtbox(); }
        private void checkBox3_Click(object sender, EventArgs e) { item_priceValue("0.00", "608.99"); quantityTxtbox(); }
        private void checkBox4_Click(object sender, EventArgs e) { item_priceValue("0.00", "700.58"); quantityTxtbox(); }
        private void checkBox5_Click(object sender, EventArgs e) { item_priceValue("0.00", "500.00"); quantityTxtbox(); }
        private void checkBox6_Click(object sender, EventArgs e) { item_priceValue("0.00", "750.00"); quantityTxtbox(); }
        private void checkBox7_Click(object sender, EventArgs e) { item_priceValue("0.00", "700.00"); quantityTxtbox(); }
        private void checkBox8_Click(object sender, EventArgs e) { item_priceValue("0.00", "850.00"); quantityTxtbox(); }
        private void checkBox9_Click(object sender, EventArgs e) { item_priceValue("0.00", "450.00"); quantityTxtbox(); }
        private void checkBox10_Click(object sender, EventArgs e) { item_priceValue("0.00", "650.00"); quantityTxtbox(); }
        private void checkBox11_Click(object sender, EventArgs e) { item_priceValue("0.00", "575.00"); quantityTxtbox(); }
        private void checkBox12_Click(object sender, EventArgs e) { item_priceValue("0.00", "575.00"); quantityTxtbox(); }
        private void checkBox13_Click(object sender, EventArgs e) { item_priceValue("0.00", "575.00"); quantityTxtbox(); }
        private void checkBox14_Click(object sender, EventArgs e) { item_priceValue("0.00", "575.00"); quantityTxtbox(); }
        private void checkBox15_Click(object sender, EventArgs e) { item_priceValue("0.00", "575.00"); quantityTxtbox(); }
        private void checkBox16_Click(object sender, EventArgs e) { item_priceValue("0.00", "575.00"); quantityTxtbox(); }
        private void checkBox17_Click(object sender, EventArgs e) { item_priceValue("0.00", "575.00"); quantityTxtbox(); }
        private void checkBox18_Click(object sender, EventArgs e) { item_priceValue("0.00", "575.00"); quantityTxtbox(); }
        private void checkBox19_Click(object sender, EventArgs e) { item_priceValue("0.00", "575.00"); quantityTxtbox(); }
        private void checkBox20_Click(object sender, EventArgs e) { item_priceValue("0.00", "575.00"); quantityTxtbox(); }
    }

    public class ReceiptForm : Form
    {
        public ReceiptForm(string receiptText)
        {
            Text = "Transaction Receipt";
            ClientSize = new Size(420, 520);
            StartPosition = FormStartPosition.CenterParent;

            TextBox receiptTxtbox = new TextBox();
            receiptTxtbox.Dock = DockStyle.Fill;
            receiptTxtbox.Multiline = true;
            receiptTxtbox.ReadOnly = true;
            receiptTxtbox.ScrollBars = ScrollBars.Vertical;
            receiptTxtbox.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            receiptTxtbox.Text = receiptText;

            Controls.Add(receiptTxtbox);
        }
    }
}
