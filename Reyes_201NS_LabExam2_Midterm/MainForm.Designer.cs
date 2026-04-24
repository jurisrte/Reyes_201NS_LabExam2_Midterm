namespace Reyes_201NS_LabExam1_Midterm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.posCashierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourJeePOSIncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourJeePOSOrderingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simplePOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posAdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourJeePOSIncAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourJeePOSOrderingAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrolApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeRegistrationPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posCashierToolStripMenuItem,
            this.posAdministratorToolStripMenuItem,
            this.userAccountToolStripMenuItem,
            this.payrolToolStripMenuItem,
            this.employeeInformationToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // posCashierToolStripMenuItem
            // 
            this.posCashierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fourJeePOSIncToolStripMenuItem,
            this.fourJeePOSOrderingToolStripMenuItem,
            this.simplePOSToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.posCashierToolStripMenuItem.Name = "posCashierToolStripMenuItem";
            this.posCashierToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.posCashierToolStripMenuItem.Text = "POS Cashier";
            // 
            // fourJeePOSIncToolStripMenuItem
            // 
            this.fourJeePOSIncToolStripMenuItem.Name = "fourJeePOSIncToolStripMenuItem";
            this.fourJeePOSIncToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.fourJeePOSIncToolStripMenuItem.Text = "4Jee POS Inc.";
            this.fourJeePOSIncToolStripMenuItem.Click += new System.EventHandler(this.OpenChildFormMenu_Click);
            // 
            // fourJeePOSOrderingToolStripMenuItem
            // 
            this.fourJeePOSOrderingToolStripMenuItem.Name = "fourJeePOSOrderingToolStripMenuItem";
            this.fourJeePOSOrderingToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.fourJeePOSOrderingToolStripMenuItem.Text = "4Jee POS Ordering";
            this.fourJeePOSOrderingToolStripMenuItem.Click += new System.EventHandler(this.OpenChildFormMenu_Click);
            // 
            // simplePOSToolStripMenuItem
            // 
            this.simplePOSToolStripMenuItem.Name = "simplePOSToolStripMenuItem";
            this.simplePOSToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.simplePOSToolStripMenuItem.Text = "Simple POS";
            this.simplePOSToolStripMenuItem.Click += new System.EventHandler(this.OpenChildFormMenu_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // posAdministratorToolStripMenuItem
            // 
            this.posAdministratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fourJeePOSIncAdminToolStripMenuItem,
            this.fourJeePOSOrderingAdminToolStripMenuItem});
            this.posAdministratorToolStripMenuItem.Name = "posAdministratorToolStripMenuItem";
            this.posAdministratorToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.posAdministratorToolStripMenuItem.Text = "POS Administrator";
            // 
            // fourJeePOSIncAdminToolStripMenuItem
            // 
            this.fourJeePOSIncAdminToolStripMenuItem.Name = "fourJeePOSIncAdminToolStripMenuItem";
            this.fourJeePOSIncAdminToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.fourJeePOSIncAdminToolStripMenuItem.Text = "4Jee POS Inc.";
            this.fourJeePOSIncAdminToolStripMenuItem.Click += new System.EventHandler(this.OpenChildFormMenu_Click);
            // 
            // fourJeePOSOrderingAdminToolStripMenuItem
            // 
            this.fourJeePOSOrderingAdminToolStripMenuItem.Name = "fourJeePOSOrderingAdminToolStripMenuItem";
            this.fourJeePOSOrderingAdminToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.fourJeePOSOrderingAdminToolStripMenuItem.Text = "4Jee POS Ordering";
            this.fourJeePOSOrderingAdminToolStripMenuItem.Click += new System.EventHandler(this.OpenChildFormMenu_Click);
            // 
            // userAccountToolStripMenuItem
            // 
            this.userAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userAccountPageToolStripMenuItem});
            this.userAccountToolStripMenuItem.Name = "userAccountToolStripMenuItem";
            this.userAccountToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.userAccountToolStripMenuItem.Text = "User Account";
            // 
            // userAccountPageToolStripMenuItem
            // 
            this.userAccountPageToolStripMenuItem.Name = "userAccountPageToolStripMenuItem";
            this.userAccountPageToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.userAccountPageToolStripMenuItem.Text = "User Account Page";
            this.userAccountPageToolStripMenuItem.Click += new System.EventHandler(this.OpenChildFormMenu_Click);
            // 
            // payrolToolStripMenuItem
            // 
            this.payrolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payrolApplicationToolStripMenuItem});
            this.payrolToolStripMenuItem.Name = "payrolToolStripMenuItem";
            this.payrolToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.payrolToolStripMenuItem.Text = "Payroll";
            // 
            // payrolApplicationToolStripMenuItem
            // 
            this.payrolApplicationToolStripMenuItem.Name = "payrolApplicationToolStripMenuItem";
            this.payrolApplicationToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.payrolApplicationToolStripMenuItem.Text = "Payroll Application";
            this.payrolApplicationToolStripMenuItem.Click += new System.EventHandler(this.OpenChildFormMenu_Click);
            // 
            // employeeInformationToolStripMenuItem
            // 
            this.employeeInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeRegistrationPageToolStripMenuItem});
            this.employeeInformationToolStripMenuItem.Name = "employeeInformationToolStripMenuItem";
            this.employeeInformationToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.employeeInformationToolStripMenuItem.Text = "Employee Information";
            // 
            // employeeRegistrationPageToolStripMenuItem
            // 
            this.employeeRegistrationPageToolStripMenuItem.Name = "employeeRegistrationPageToolStripMenuItem";
            this.employeeRegistrationPageToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.employeeRegistrationPageToolStripMenuItem.Text = "Employee Registration Page";
            this.employeeRegistrationPageToolStripMenuItem.Click += new System.EventHandler(this.OpenChildFormMenu_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesReportsToolStripMenuItem,
            this.productReportsToolStripMenuItem,
            this.employeesReportsToolStripMenuItem,
            this.payrollReportsToolStripMenuItem,
            this.userReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // salesReportsToolStripMenuItem
            // 
            this.salesReportsToolStripMenuItem.Name = "salesReportsToolStripMenuItem";
            this.salesReportsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.salesReportsToolStripMenuItem.Text = "Sales Reports";
            this.salesReportsToolStripMenuItem.Click += new System.EventHandler(this.OpenChildFormMenu_Click);
            // 
            // productReportsToolStripMenuItem
            // 
            this.productReportsToolStripMenuItem.Name = "productReportsToolStripMenuItem";
            this.productReportsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.productReportsToolStripMenuItem.Text = "Product Reports";
            this.productReportsToolStripMenuItem.Click += new System.EventHandler(this.OpenChildFormMenu_Click);
            // 
            // employeesReportsToolStripMenuItem
            // 
            this.employeesReportsToolStripMenuItem.Name = "employeesReportsToolStripMenuItem";
            this.employeesReportsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.employeesReportsToolStripMenuItem.Text = "Employees Reports";
            this.employeesReportsToolStripMenuItem.Click += new System.EventHandler(this.OpenChildFormMenu_Click);
            // 
            // payrollReportsToolStripMenuItem
            // 
            this.payrollReportsToolStripMenuItem.Name = "payrollReportsToolStripMenuItem";
            this.payrollReportsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.payrollReportsToolStripMenuItem.Text = "Payroll Reports";
            this.payrollReportsToolStripMenuItem.Click += new System.EventHandler(this.OpenChildFormMenu_Click);
            // 
            // userReportsToolStripMenuItem
            // 
            this.userReportsToolStripMenuItem.Name = "userReportsToolStripMenuItem";
            this.userReportsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.userReportsToolStripMenuItem.Text = "User Reports";
            this.userReportsToolStripMenuItem.Click += new System.EventHandler(this.OpenChildFormMenu_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.cascadeToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(30, 22);
            this.toolStripLabel1.Text = "POS";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem posCashierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fourJeePOSIncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fourJeePOSOrderingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simplePOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posAdministratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fourJeePOSIncAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fourJeePOSOrderingAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccountPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrolApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeRegistrationPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

