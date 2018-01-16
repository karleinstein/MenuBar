namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class TaskSchedulerAccntInfoDlg : Form
    {
        private Label c1e59f79796c93d0243c42be652bf4f64;
        internal string c21e33fe9af6bcf9d41a273537982a3f2;
        internal string c386916c2f09f86f9474ff0deda573fdc;
        private Button c407f1a22fa47f71ef54c923608edc053;
        private Container c469770157ab2c17cf4bcb42431e5cfe5;
        private Label c4b6c01b1d8847726c95ec1b20cfe89b5;
        private TextBox c617b625b80376e9cb016f473ef500997;
        private TextBox c80884596f3b559f1d6b9d1bb26eb0d28;
        private Button c9b2a6641158eab6297d36f57afb0335e;
        private Button ca140bfb2803fdf5e51c61239d6e6c760;
        internal string ca9a501ac55f2734a8e6ef218f6cd7dde;
        private TextBox cb197192b735b0dca140e33fa6dad64f2;
        private OpenFileDialog cdb3e94ef77a55731d99350a1cdcb976a;
        private Label cf328afe1ce3a8d0dee5578a17e54052b;

        public TaskSchedulerAccntInfoDlg()
        {
            this.c1b290032ef9b41c7e7dfa4c37bfceb6d();
        }

        private void c1186c0e88c5b95d1280f74b021cffe99(object c32c3d50ef5725e6c8f1a2ea14bb42003, EventArgs c2bba0636d27ec9b98b39d7d3d3d4f2c9)
        {
            string text = this.c80884596f3b559f1d6b9d1bb26eb0d28.Text;
            this.c21e33fe9af6bcf9d41a273537982a3f2 = text;
            string text2 = this.c617b625b80376e9cb016f473ef500997.Text;
            this.c386916c2f09f86f9474ff0deda573fdc = text2;
            string text3 = this.cb197192b735b0dca140e33fa6dad64f2.Text;
            this.ca9a501ac55f2734a8e6ef218f6cd7dde = text3;
            base.Close();
        }

        private void c199d9dea8932c991d512fd1497395278(object c32c3d50ef5725e6c8f1a2ea14bb42003, EventArgs c2bba0636d27ec9b98b39d7d3d3d4f2c9)
        {
            DialogResult result2 = this.cdb3e94ef77a55731d99350a1cdcb976a.ShowDialog();
            if (result2 != DialogResult.OK)
            {
                return;
            }
        Label_0010:
            switch (4)
            {
                case 0:
                    goto Label_0010;

                default:
                {
                    if (1 == 0)
                    {
                    }
                    string fileName = this.cdb3e94ef77a55731d99350a1cdcb976a.FileName;
                    this.c80884596f3b559f1d6b9d1bb26eb0d28.Text = fileName;
                    break;
                }
            }
        }

        private void c1b290032ef9b41c7e7dfa4c37bfceb6d()
        {
            this.cf328afe1ce3a8d0dee5578a17e54052b = new Label();
            this.c617b625b80376e9cb016f473ef500997 = new TextBox();
            this.cb197192b735b0dca140e33fa6dad64f2 = new TextBox();
            this.c4b6c01b1d8847726c95ec1b20cfe89b5 = new Label();
            this.c407f1a22fa47f71ef54c923608edc053 = new Button();
            this.c9b2a6641158eab6297d36f57afb0335e = new Button();
            this.c80884596f3b559f1d6b9d1bb26eb0d28 = new TextBox();
            this.c1e59f79796c93d0243c42be652bf4f64 = new Label();
            this.ca140bfb2803fdf5e51c61239d6e6c760 = new Button();
            this.cdb3e94ef77a55731d99350a1cdcb976a = new OpenFileDialog();
            base.SuspendLayout();
            this.cf328afe1ce3a8d0dee5578a17e54052b.Location = new Point(0x10, 0x48);
            this.cf328afe1ce3a8d0dee5578a17e54052b.Name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x17a);
            this.cf328afe1ce3a8d0dee5578a17e54052b.Size = new Size(0x98, 0x18);
            this.cf328afe1ce3a8d0dee5578a17e54052b.TabIndex = 0;
            string text1 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xa8e);
            this.cf328afe1ce3a8d0dee5578a17e54052b.Text = text1;
            this.cf328afe1ce3a8d0dee5578a17e54052b.Click += new EventHandler(this.c2d9339b9d59f66cdf66dde45343f98fd);
            this.c617b625b80376e9cb016f473ef500997.Location = new Point(0x10, 0x68);
            this.c617b625b80376e9cb016f473ef500997.Name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xaa7);
            this.c617b625b80376e9cb016f473ef500997.Size = new Size(0x98, 20);
            this.c617b625b80376e9cb016f473ef500997.TabIndex = 1;
            this.c617b625b80376e9cb016f473ef500997.Text = "";
            this.cb197192b735b0dca140e33fa6dad64f2.Location = new Point(0xb0, 0x68);
            string text2 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xac4);
            this.cb197192b735b0dca140e33fa6dad64f2.Name = text2;
            this.cb197192b735b0dca140e33fa6dad64f2.PasswordChar = '*';
            this.cb197192b735b0dca140e33fa6dad64f2.Size = new Size(0x98, 20);
            this.cb197192b735b0dca140e33fa6dad64f2.TabIndex = 2;
            this.cb197192b735b0dca140e33fa6dad64f2.Text = "";
            this.c4b6c01b1d8847726c95ec1b20cfe89b5.Location = new Point(0xb0, 0x48);
            string text3 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xadb);
            this.c4b6c01b1d8847726c95ec1b20cfe89b5.Name = text3;
            this.c4b6c01b1d8847726c95ec1b20cfe89b5.Size = new Size(0x98, 0x18);
            this.c4b6c01b1d8847726c95ec1b20cfe89b5.TabIndex = 3;
            string text4 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xae8);
            this.c4b6c01b1d8847726c95ec1b20cfe89b5.Text = text4;
            this.c4b6c01b1d8847726c95ec1b20cfe89b5.Click += new EventHandler(this.c3141246bf13636c70eefc1a6ae65cc43);
            this.c407f1a22fa47f71ef54c923608edc053.Location = new Point(0xb0, 0x88);
            string text5 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xaf9);
            this.c407f1a22fa47f71ef54c923608edc053.Name = text5;
            this.c407f1a22fa47f71ef54c923608edc053.Size = new Size(0x40, 0x20);
            this.c407f1a22fa47f71ef54c923608edc053.TabIndex = 4;
            this.c407f1a22fa47f71ef54c923608edc053.Text = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xb04);
            this.c407f1a22fa47f71ef54c923608edc053.Click += new EventHandler(this.c1186c0e88c5b95d1280f74b021cffe99);
            this.c9b2a6641158eab6297d36f57afb0335e.DialogResult = DialogResult.Cancel;
            this.c9b2a6641158eab6297d36f57afb0335e.Location = new Point(0x108, 0x88);
            string text6 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xb09);
            this.c9b2a6641158eab6297d36f57afb0335e.Name = text6;
            this.c9b2a6641158eab6297d36f57afb0335e.Size = new Size(0x40, 0x20);
            this.c9b2a6641158eab6297d36f57afb0335e.TabIndex = 5;
            this.c9b2a6641158eab6297d36f57afb0335e.Text = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xb1c);
            this.c9b2a6641158eab6297d36f57afb0335e.Click += new EventHandler(this.c2ce63863c5de4b7a29aae14c371332c5);
            this.c80884596f3b559f1d6b9d1bb26eb0d28.Location = new Point(0x10, 40);
            string text7 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xb29);
            this.c80884596f3b559f1d6b9d1bb26eb0d28.Name = text7;
            this.c80884596f3b559f1d6b9d1bb26eb0d28.Size = new Size(280, 20);
            this.c80884596f3b559f1d6b9d1bb26eb0d28.TabIndex = 6;
            this.c80884596f3b559f1d6b9d1bb26eb0d28.Text = "";
            this.c1e59f79796c93d0243c42be652bf4f64.Location = new Point(0x10, 8);
            string text8 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x20b);
            this.c1e59f79796c93d0243c42be652bf4f64.Name = text8;
            this.c1e59f79796c93d0243c42be652bf4f64.Size = new Size(0x98, 0x18);
            this.c1e59f79796c93d0243c42be652bf4f64.TabIndex = 7;
            string text9 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xb4e);
            this.c1e59f79796c93d0243c42be652bf4f64.Text = text9;
            this.ca140bfb2803fdf5e51c61239d6e6c760.Font = new Font(c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x151), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ca140bfb2803fdf5e51c61239d6e6c760.Location = new Point(0x130, 40);
            this.ca140bfb2803fdf5e51c61239d6e6c760.Name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xb6f);
            this.ca140bfb2803fdf5e51c61239d6e6c760.Size = new Size(0x18, 0x18);
            this.ca140bfb2803fdf5e51c61239d6e6c760.TabIndex = 8;
            this.ca140bfb2803fdf5e51c61239d6e6c760.Text = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xb82);
            this.ca140bfb2803fdf5e51c61239d6e6c760.TextAlign = ContentAlignment.TopCenter;
            this.ca140bfb2803fdf5e51c61239d6e6c760.Click += new EventHandler(this.c199d9dea8932c991d512fd1497395278);
            string text10 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xb89);
            this.cdb3e94ef77a55731d99350a1cdcb976a.Filter = text10;
            string text11 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xbb8);
            this.cdb3e94ef77a55731d99350a1cdcb976a.Title = text11;
            base.AcceptButton = this.c407f1a22fa47f71ef54c923608edc053;
            this.AutoScaleBaseSize = new Size(5, 13);
            base.CancelButton = this.c9b2a6641158eab6297d36f57afb0335e;
            base.ClientSize = new Size(350, 0xbc);
            base.Controls.AddRange(new Control[] { this.ca140bfb2803fdf5e51c61239d6e6c760, this.c1e59f79796c93d0243c42be652bf4f64, this.c80884596f3b559f1d6b9d1bb26eb0d28, this.c9b2a6641158eab6297d36f57afb0335e, this.c407f1a22fa47f71ef54c923608edc053, this.c4b6c01b1d8847726c95ec1b20cfe89b5, this.cb197192b735b0dca140e33fa6dad64f2, this.c617b625b80376e9cb016f473ef500997, this.cf328afe1ce3a8d0dee5578a17e54052b });
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximumSize = new Size(360, 0xe0);
            this.MinimumSize = new Size(360, 0xe0);
            base.Name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xbe5);
            string text12 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xbfe);
            this.Text = text12;
            base.Load += new EventHandler(this.c863a51de9c2cac8f040b3fe9bed30487);
            base.ResumeLayout(false);
        }

        private void c2ce63863c5de4b7a29aae14c371332c5(object c32c3d50ef5725e6c8f1a2ea14bb42003, EventArgs c2bba0636d27ec9b98b39d7d3d3d4f2c9)
        {
            base.Close();
        }

        private void c2d9339b9d59f66cdf66dde45343f98fd(object c32c3d50ef5725e6c8f1a2ea14bb42003, EventArgs c2bba0636d27ec9b98b39d7d3d3d4f2c9)
        {
        }

        private void c3141246bf13636c70eefc1a6ae65cc43(object c32c3d50ef5725e6c8f1a2ea14bb42003, EventArgs c2bba0636d27ec9b98b39d7d3d3d4f2c9)
        {
        }

        private void c863a51de9c2cac8f040b3fe9bed30487(object c32c3d50ef5725e6c8f1a2ea14bb42003, EventArgs c2bba0636d27ec9b98b39d7d3d3d4f2c9)
        {
            this.c617b625b80376e9cb016f473ef500997.Text = this.c386916c2f09f86f9474ff0deda573fdc;
            this.c80884596f3b559f1d6b9d1bb26eb0d28.Text = this.c21e33fe9af6bcf9d41a273537982a3f2;
        }

        protected override void Dispose(bool disposing)
        {
            if (!disposing)
            {
                goto Label_0029;
            }
        Label_0003:
            switch (6)
            {
                case 0:
                    goto Label_0003;

                default:
                    if (1 == 0)
                    {
                    }
                    if (this.c469770157ab2c17cf4bcb42431e5cfe5 != null)
                    {
                        this.c469770157ab2c17cf4bcb42431e5cfe5.Dispose();
                    }
                    break;
            }
        Label_0029:
            base.Dispose(disposing);
        }
    }
}

