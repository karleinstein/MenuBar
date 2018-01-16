namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class SystemHotKeyEditor : Form
    {
        private Button c19f76aacc79c595adf668e30e3adf6c9;
        private Label c1e59f79796c93d0243c42be652bf4f64;
        private TextBox c1fa94719601dbe36472382cc2ca6a3e6;
        private Container c469770157ab2c17cf4bcb42431e5cfe5;
        private Label c4b6c01b1d8847726c95ec1b20cfe89b5;
        private CheckBox c4f87bf351a1de5658a7197d58a786963;
        private CheckBox c60d7235c8b764994456e271241c4de04;
        internal cfa5aa368e7262ba8e7c2f18478ea71e0 c6902301418a3edf088649b116e8e631d;
        private Button c9b2a6641158eab6297d36f57afb0335e;
        private CheckBox ca66a13ae5977351b2cccf2fca029a5be;
        private CheckBox cb86db132c4f6d193dc502b3e39164243;
        private Panel ce36d37b55606e3f02f67e208ef19ec8c;
        private Label cf328afe1ce3a8d0dee5578a17e54052b;

        public SystemHotKeyEditor()
        {
            this.c1b290032ef9b41c7e7dfa4c37bfceb6d();
        }

        private void c1186c0e88c5b95d1280f74b021cffe99(object c32c3d50ef5725e6c8f1a2ea14bb42003, EventArgs c2bba0636d27ec9b98b39d7d3d3d4f2c9)
        {
            try
            {
                System.Type type2;
                KeyModifiers none = KeyModifiers.None;
                if (!this.ca66a13ae5977351b2cccf2fca029a5be.Checked)
                {
                    goto Label_0026;
                }
            Label_000F:
                switch (1)
                {
                    case 0:
                        goto Label_000F;

                    default:
                        if (1 == 0)
                        {
                        }
                        none |= KeyModifiers.Alt;
                        break;
                }
            Label_0026:
                if (!this.cb86db132c4f6d193dc502b3e39164243.Checked)
                {
                    goto Label_0041;
                }
            Label_0033:
                switch (4)
                {
                    case 0:
                        goto Label_0033;

                    default:
                        none |= KeyModifiers.Control;
                        break;
                }
            Label_0041:
                if (!this.c4f87bf351a1de5658a7197d58a786963.Checked)
                {
                    goto Label_005E;
                }
            Label_0050:
                switch (5)
                {
                    case 0:
                        goto Label_0050;

                    default:
                        none |= KeyModifiers.Shift;
                        break;
                }
            Label_005E:
                if (!this.c60d7235c8b764994456e271241c4de04.Checked)
                {
                    goto Label_0079;
                }
            Label_006B:
                switch (3)
                {
                    case 0:
                        goto Label_006B;

                    default:
                        none |= KeyModifiers.Win;
                        break;
                }
            Label_0079:
                type2 = typeof(Keys);
                string text = this.c1fa94719601dbe36472382cc2ca6a3e6.Text;
                object obj3 = Enum.Parse(type2, text);
                Keys keys = (Keys) obj3;
                this.c6902301418a3edf088649b116e8e631d.cbb54993ced46008451a87fbe1842ccbd(keys, none);
                this.c6902301418a3edf088649b116e8e631d.c3dec5d5039b98eb2d4080a89603d3266();
            }
            catch
            {
            }
            base.Close();
        }

        private void c1b290032ef9b41c7e7dfa4c37bfceb6d()
        {
            this.c1fa94719601dbe36472382cc2ca6a3e6 = new TextBox();
            this.cb86db132c4f6d193dc502b3e39164243 = new CheckBox();
            this.c4f87bf351a1de5658a7197d58a786963 = new CheckBox();
            this.ca66a13ae5977351b2cccf2fca029a5be = new CheckBox();
            this.c60d7235c8b764994456e271241c4de04 = new CheckBox();
            this.cf328afe1ce3a8d0dee5578a17e54052b = new Label();
            this.c4b6c01b1d8847726c95ec1b20cfe89b5 = new Label();
            this.c1e59f79796c93d0243c42be652bf4f64 = new Label();
            this.c19f76aacc79c595adf668e30e3adf6c9 = new Button();
            this.ce36d37b55606e3f02f67e208ef19ec8c = new Panel();
            this.c9b2a6641158eab6297d36f57afb0335e = new Button();
            base.SuspendLayout();
            this.c1fa94719601dbe36472382cc2ca6a3e6.BorderStyle = BorderStyle.FixedSingle;
            this.c1fa94719601dbe36472382cc2ca6a3e6.Location = new Point(0x178, 0x30);
            string text1 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x35e4);
            this.c1fa94719601dbe36472382cc2ca6a3e6.Name = text1;
            this.c1fa94719601dbe36472382cc2ca6a3e6.ReadOnly = true;
            this.c1fa94719601dbe36472382cc2ca6a3e6.Size = new Size(0x80, 0x16);
            this.c1fa94719601dbe36472382cc2ca6a3e6.TabIndex = 0;
            string text2 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x35f1);
            this.c1fa94719601dbe36472382cc2ca6a3e6.Text = text2;
            this.c1fa94719601dbe36472382cc2ca6a3e6.TextAlign = HorizontalAlignment.Center;
            this.c1fa94719601dbe36472382cc2ca6a3e6.KeyDown += new KeyEventHandler(this.c1f82f98f4ef7235fe46784e4c4fd3c63);
            this.cb86db132c4f6d193dc502b3e39164243.Location = new Point(0x10, 0x30);
            string text3 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x3602);
            this.cb86db132c4f6d193dc502b3e39164243.Name = text3;
            this.cb86db132c4f6d193dc502b3e39164243.Size = new Size(0x48, 0x16);
            this.cb86db132c4f6d193dc502b3e39164243.TabIndex = 1;
            string text4 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x3611);
            this.cb86db132c4f6d193dc502b3e39164243.Text = text4;
            this.c4f87bf351a1de5658a7197d58a786963.Location = new Point(0x58, 0x30);
            string text5 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x361a);
            this.c4f87bf351a1de5658a7197d58a786963.Name = text5;
            this.c4f87bf351a1de5658a7197d58a786963.Size = new Size(0x48, 0x16);
            this.c4f87bf351a1de5658a7197d58a786963.TabIndex = 1;
            string text6 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x362b);
            this.c4f87bf351a1de5658a7197d58a786963.Text = text6;
            this.ca66a13ae5977351b2cccf2fca029a5be.Location = new Point(0xa8, 0x30);
            this.ca66a13ae5977351b2cccf2fca029a5be.Name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x3636);
            this.ca66a13ae5977351b2cccf2fca029a5be.Size = new Size(0x48, 0x16);
            this.ca66a13ae5977351b2cccf2fca029a5be.TabIndex = 1;
            string text7 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x3643);
            this.ca66a13ae5977351b2cccf2fca029a5be.Text = text7;
            this.c60d7235c8b764994456e271241c4de04.Location = new Point(240, 0x30);
            this.c60d7235c8b764994456e271241c4de04.Name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x364a);
            this.c60d7235c8b764994456e271241c4de04.Size = new Size(0x48, 0x16);
            this.c60d7235c8b764994456e271241c4de04.TabIndex = 1;
            this.c60d7235c8b764994456e271241c4de04.Text = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x3657);
            this.cf328afe1ce3a8d0dee5578a17e54052b.Location = new Point(0x10, 8);
            string text8 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x17a);
            this.cf328afe1ce3a8d0dee5578a17e54052b.Name = text8;
            this.cf328afe1ce3a8d0dee5578a17e54052b.Size = new Size(280, 0x18);
            this.cf328afe1ce3a8d0dee5578a17e54052b.TabIndex = 2;
            string text9 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x365e);
            this.cf328afe1ce3a8d0dee5578a17e54052b.Text = text9;
            this.c4b6c01b1d8847726c95ec1b20cfe89b5.Location = new Point(0x170, 8);
            string text10 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xadb);
            this.c4b6c01b1d8847726c95ec1b20cfe89b5.Name = text10;
            this.c4b6c01b1d8847726c95ec1b20cfe89b5.Size = new Size(0xd8, 0x18);
            this.c4b6c01b1d8847726c95ec1b20cfe89b5.TabIndex = 3;
            string text11 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x3695);
            this.c4b6c01b1d8847726c95ec1b20cfe89b5.Text = text11;
            string familyName = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x151);
            this.c1e59f79796c93d0243c42be652bf4f64.Font = new Font(familyName, 10f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.c1e59f79796c93d0243c42be652bf4f64.Location = new Point(320, 0x30);
            string text13 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x20b);
            this.c1e59f79796c93d0243c42be652bf4f64.Name = text13;
            this.c1e59f79796c93d0243c42be652bf4f64.Size = new Size(40, 0x16);
            this.c1e59f79796c93d0243c42be652bf4f64.TabIndex = 4;
            string text14 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x36d4);
            this.c1e59f79796c93d0243c42be652bf4f64.Text = text14;
            this.c19f76aacc79c595adf668e30e3adf6c9.DialogResult = DialogResult.OK;
            this.c19f76aacc79c595adf668e30e3adf6c9.Location = new Point(0x150, 0x68);
            string text15 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x1103);
            this.c19f76aacc79c595adf668e30e3adf6c9.Name = text15;
            this.c19f76aacc79c595adf668e30e3adf6c9.Size = new Size(0x70, 0x20);
            this.c19f76aacc79c595adf668e30e3adf6c9.TabIndex = 5;
            string text16 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xb04);
            this.c19f76aacc79c595adf668e30e3adf6c9.Text = text16;
            this.c19f76aacc79c595adf668e30e3adf6c9.Click += new EventHandler(this.c1186c0e88c5b95d1280f74b021cffe99);
            this.ce36d37b55606e3f02f67e208ef19ec8c.BorderStyle = BorderStyle.FixedSingle;
            this.ce36d37b55606e3f02f67e208ef19ec8c.Location = new Point(8, 0x58);
            string text17 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x1b1a);
            this.ce36d37b55606e3f02f67e208ef19ec8c.Name = text17;
            this.ce36d37b55606e3f02f67e208ef19ec8c.Size = new Size(0x235, 2);
            this.ce36d37b55606e3f02f67e208ef19ec8c.TabIndex = 6;
            this.c9b2a6641158eab6297d36f57afb0335e.DialogResult = DialogResult.Cancel;
            this.c9b2a6641158eab6297d36f57afb0335e.Location = new Point(0x1d0, 0x68);
            string text18 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xb09);
            this.c9b2a6641158eab6297d36f57afb0335e.Name = text18;
            this.c9b2a6641158eab6297d36f57afb0335e.Size = new Size(0x70, 0x20);
            this.c9b2a6641158eab6297d36f57afb0335e.TabIndex = 7;
            string text19 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xb1c);
            this.c9b2a6641158eab6297d36f57afb0335e.Text = text19;
            this.AutoScaleBaseSize = new Size(6, 15);
            base.ClientSize = new Size(0x250, 0x98);
            base.Controls.AddRange(new Control[] { this.c9b2a6641158eab6297d36f57afb0335e, this.ce36d37b55606e3f02f67e208ef19ec8c, this.c19f76aacc79c595adf668e30e3adf6c9, this.c1e59f79796c93d0243c42be652bf4f64, this.c4b6c01b1d8847726c95ec1b20cfe89b5, this.cf328afe1ce3a8d0dee5578a17e54052b, this.cb86db132c4f6d193dc502b3e39164243, this.c1fa94719601dbe36472382cc2ca6a3e6, this.c4f87bf351a1de5658a7197d58a786963, this.ca66a13ae5977351b2cccf2fca029a5be, this.c60d7235c8b764994456e271241c4de04 });
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x36d7);
            string text20 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x36d7);
            this.Text = text20;
            base.Closing += new CancelEventHandler(this.c484d892262fb633fa1ea4fe893213e40);
            base.Load += new EventHandler(this.cc6fb5c9c5a92bd607197213e4955db56);
            base.ResumeLayout(false);
        }

        private void c1f82f98f4ef7235fe46784e4c4fd3c63(object c32c3d50ef5725e6c8f1a2ea14bb42003, KeyEventArgs c2bba0636d27ec9b98b39d7d3d3d4f2c9)
        {
            string str = c2bba0636d27ec9b98b39d7d3d3d4f2c9.KeyCode.ToString();
            this.c1fa94719601dbe36472382cc2ca6a3e6.Text = str;
        }

        private void c484d892262fb633fa1ea4fe893213e40(object c32c3d50ef5725e6c8f1a2ea14bb42003, CancelEventArgs c2bba0636d27ec9b98b39d7d3d3d4f2c9)
        {
        }

        private void cc6fb5c9c5a92bd607197213e4955db56(object c32c3d50ef5725e6c8f1a2ea14bb42003, EventArgs c2bba0636d27ec9b98b39d7d3d3d4f2c9)
        {
            if ((this.c6902301418a3edf088649b116e8e631d.c8296d0f03bfe307297eb785098596c72 & KeyModifiers.Alt) == KeyModifiers.None)
            {
                goto Label_002E;
            }
        Label_000F:
            switch (3)
            {
                case 0:
                    goto Label_000F;

                default:
                    if (1 == 0)
                    {
                    }
                    this.ca66a13ae5977351b2cccf2fca029a5be.Checked = true;
                    break;
            }
        Label_002E:
            if ((this.c6902301418a3edf088649b116e8e631d.c8296d0f03bfe307297eb785098596c72 & KeyModifiers.Control) != KeyModifiers.None)
            {
                this.cb86db132c4f6d193dc502b3e39164243.Checked = true;
            }
            if ((this.c6902301418a3edf088649b116e8e631d.c8296d0f03bfe307297eb785098596c72 & KeyModifiers.Shift) == KeyModifiers.None)
            {
                goto Label_006E;
            }
        Label_0058:
            switch (6)
            {
                case 0:
                    goto Label_0058;

                default:
                    this.c4f87bf351a1de5658a7197d58a786963.Checked = true;
                    break;
            }
        Label_006E:
            if ((this.c6902301418a3edf088649b116e8e631d.c8296d0f03bfe307297eb785098596c72 & KeyModifiers.Win) != KeyModifiers.None)
            {
                this.c60d7235c8b764994456e271241c4de04.Checked = true;
            }
            string text2 = this.c6902301418a3edf088649b116e8e631d.cdfe42567d89e984df05b82b933333f5c.ToString();
            this.c1fa94719601dbe36472382cc2ca6a3e6.Text = text2;
        }

        protected override void Dispose(bool disposing)
        {
            if (!disposing || (this.c469770157ab2c17cf4bcb42431e5cfe5 == null))
            {
                goto Label_0029;
            }
        Label_000B:
            switch (6)
            {
                case 0:
                    goto Label_000B;

                default:
                    if (1 == 0)
                    {
                    }
                    this.c469770157ab2c17cf4bcb42431e5cfe5.Dispose();
                    break;
            }
        Label_0029:
            base.Dispose(disposing);
        }
    }
}

