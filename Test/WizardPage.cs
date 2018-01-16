namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [Designer("LogicNP.ShellObjects.Design.WizardPageDesigner, LogicNP.ShellObjects.Design"), ToolboxItem(false)]
    public class WizardPage : Panel
    {
        internal WizardPageType c00649d7e6c9adb59ef7fd8dacf8c34ae;
        internal AutoBoolean c0f183e8414cb94885adce81249b7b97b;
        internal Image c12a74bd6ba71508a050dd1e73647d36d;
        internal LogicNP.ShellObjects.Wizard c1ddc887212aafbd9ba7cb9b75b60e84e;
        internal string c2bbc876fadd7032d696b137bfa5c2a9c;
        internal int c2c722cb7e32a87966531a1e4c598d61d;
        private Container c469770157ab2c17cf4bcb42431e5cfe5;
        private EventHandler c4a4984a2da6e74aaca58d081b737e58b;
        internal AutoBoolean c4ccb15ae364b5bb64fd18a538f12488d;
        internal IWizardPainter c6e26ff980e0b200f1325323b389d13c3;
        private CancelEventHandler c6f82e885b3ff147b92417572eda22e69;
        private EventHandler c705e3febeb6f4d93b05016e670f1a73d;
        private WizardPageCancelEventHandler c73e4f2e20d6b2343616f4ac408342906;
        internal AutoBoolean c7c201e0755dc3bdf39293fd8f4ec10a9;
        internal AutoBoolean c82fb15376ca8f128e6c409e924aa288f;
        private CancelEventHandler c86b33e9d4d2b46d49da06ec1058dfecb;
        internal string c924a7adae948f7734a40ae82ec69a136;
        internal AutoBoolean c9363b2573ec6976255b107de9714a88d;
        internal AutoBoolean c98d2bb12edb2dcd34d12b0d266c30ae4;
        internal AutoBoolean cbd69662b502356b5738f77fa62d8caa9;
        internal string cc3d6949ec78400327ca47995273eba25;
        internal AutoBoolean ccc0f6bd83b90e0c6dad93b05402e740e;
        private WizardPageCancelEventHandler cd09e3f671d59f7a579ccfe901a8f5f85;
        internal AutoBoolean cd0f713933438f34835b01297433a8a7f;
        internal int cd3827007acc399b34f956117869414d0;
        internal AutoBoolean ce01eec33f178a777b002386272adadf9;
        internal AutoBoolean ce4d2f1b450cdabfd1f0f4f28ea6b3800;
        internal AutoBoolean ce61c1bfa143f12ef54e4723680141300;
        private WizardPageCancelEventHandler cf608572e9306003c3e0ba8e54284f840;
        private CancelEventHandler cf81878b068b3b3d496b7c8529c3b1077;

        [Description("Occurs after the page is hidden"), Category("WizardPage")]
        public event EventHandler AfterHide
        {
            [MethodImpl(MethodImplOptions.Synchronized)] add
            {
                this.c705e3febeb6f4d93b05016e670f1a73d = (EventHandler) Delegate.Combine(this.c705e3febeb6f4d93b05016e670f1a73d, value);
            }
            [MethodImpl(MethodImplOptions.Synchronized)] remove
            {
                Delegate delegate1 = Delegate.Remove(this.c705e3febeb6f4d93b05016e670f1a73d, value);
                this.c705e3febeb6f4d93b05016e670f1a73d = (EventHandler) delegate1;
            }
        }

        [Description("Occurs after the page is shown"), Category("WizardPage")]
        public event EventHandler AfterShow
        {
            [MethodImpl(MethodImplOptions.Synchronized)] add
            {
                Delegate delegate1 = Delegate.Combine(this.c4a4984a2da6e74aaca58d081b737e58b, value);
                this.c4a4984a2da6e74aaca58d081b737e58b = (EventHandler) delegate1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)] remove
            {
                this.c4a4984a2da6e74aaca58d081b737e58b = (EventHandler) Delegate.Remove(this.c4a4984a2da6e74aaca58d081b737e58b, value);
            }
        }

        [Category("WizardPage"), Description("Occurs when the Back button is clicked")]
        public event WizardPageCancelEventHandler BackButtonClick
        {
            [MethodImpl(MethodImplOptions.Synchronized)] add
            {
                this.cf608572e9306003c3e0ba8e54284f840 = (WizardPageCancelEventHandler) Delegate.Combine(this.cf608572e9306003c3e0ba8e54284f840, value);
            }
            [MethodImpl(MethodImplOptions.Synchronized)] remove
            {
                Delegate delegate1 = Delegate.Remove(this.cf608572e9306003c3e0ba8e54284f840, value);
                this.cf608572e9306003c3e0ba8e54284f840 = (WizardPageCancelEventHandler) delegate1;
            }
        }

        [Description("Occurs before the page is hidden"), Category("WizardPage")]
        public event WizardPageCancelEventHandler BeforeHide
        {
            [MethodImpl(MethodImplOptions.Synchronized)] add
            {
                this.c73e4f2e20d6b2343616f4ac408342906 = (WizardPageCancelEventHandler) Delegate.Combine(this.c73e4f2e20d6b2343616f4ac408342906, value);
            }
            [MethodImpl(MethodImplOptions.Synchronized)] remove
            {
                Delegate delegate1 = Delegate.Remove(this.c73e4f2e20d6b2343616f4ac408342906, value);
                this.c73e4f2e20d6b2343616f4ac408342906 = (WizardPageCancelEventHandler) delegate1;
            }
        }

        [Category("WizardPage"), Description("Occurs before the page is shown")]
        public event WizardPageCancelEventHandler BeforeShow
        {
            [MethodImpl(MethodImplOptions.Synchronized)] add
            {
                Delegate delegate1 = Delegate.Combine(this.cd09e3f671d59f7a579ccfe901a8f5f85, value);
                this.cd09e3f671d59f7a579ccfe901a8f5f85 = (WizardPageCancelEventHandler) delegate1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)] remove
            {
                Delegate delegate1 = Delegate.Remove(this.cd09e3f671d59f7a579ccfe901a8f5f85, value);
                this.cd09e3f671d59f7a579ccfe901a8f5f85 = (WizardPageCancelEventHandler) delegate1;
            }
        }

        [Description("Occurs when the Cancel button is clicked"), Category("WizardPage")]
        public event CancelEventHandler CancelButtonClick
        {
            [MethodImpl(MethodImplOptions.Synchronized)] add
            {
                Delegate delegate1 = Delegate.Combine(this.c86b33e9d4d2b46d49da06ec1058dfecb, value);
                this.c86b33e9d4d2b46d49da06ec1058dfecb = (CancelEventHandler) delegate1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)] remove
            {
                Delegate delegate1 = Delegate.Remove(this.c86b33e9d4d2b46d49da06ec1058dfecb, value);
                this.c86b33e9d4d2b46d49da06ec1058dfecb = (CancelEventHandler) delegate1;
            }
        }

        [Category("WizardPage"), Description("Occurs when the Finish button is clicked")]
        public event CancelEventHandler FinishButtonClick
        {
            [MethodImpl(MethodImplOptions.Synchronized)] add
            {
                Delegate delegate1 = Delegate.Combine(this.c6f82e885b3ff147b92417572eda22e69, value);
                this.c6f82e885b3ff147b92417572eda22e69 = (CancelEventHandler) delegate1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)] remove
            {
                Delegate delegate1 = Delegate.Remove(this.c6f82e885b3ff147b92417572eda22e69, value);
                this.c6f82e885b3ff147b92417572eda22e69 = (CancelEventHandler) delegate1;
            }
        }

        [Description("Occurs when the Help button is clicked"), Category("WizardPage")]
        public event CancelEventHandler HelpButtonClick
        {
            [MethodImpl(MethodImplOptions.Synchronized)] add
            {
                Delegate delegate1 = Delegate.Combine(this.cf81878b068b3b3d496b7c8529c3b1077, value);
                this.cf81878b068b3b3d496b7c8529c3b1077 = (CancelEventHandler) delegate1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)] remove
            {
                Delegate delegate1 = Delegate.Remove(this.cf81878b068b3b3d496b7c8529c3b1077, value);
                this.cf81878b068b3b3d496b7c8529c3b1077 = (CancelEventHandler) delegate1;
            }
        }

        [Category("WizardPage"), Description("Occurs when the Next button is clicked")]
        public event WizardPageCancelEventHandler NextButtonClick;

        public WizardPage()
        {
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.DoubleBuffer, true);
            this.c1b290032ef9b41c7e7dfa4c37bfceb6d();
            this.cac39076a0a300436ec8a3a1fe9b2fcda();
        }

        private void c1b290032ef9b41c7e7dfa4c37bfceb6d()
        {
            base.Size = new Size(0x220, 0x160);
        }

        private void cac39076a0a300436ec8a3a1fe9b2fcda()
        {
            this.cd3827007acc399b34f956117869414d0 = 150;
            this.c2c722cb7e32a87966531a1e4c598d61d = 60;
            this.cd0f713933438f34835b01297433a8a7f = AutoBoolean.Auto;
            this.ce4d2f1b450cdabfd1f0f4f28ea6b3800 = AutoBoolean.False;
            string text1 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x273b);
            this.c924a7adae948f7734a40ae82ec69a136 = text1;
            string text2 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x2754);
            this.c2bbc876fadd7032d696b137bfa5c2a9c = text2;
            this.cc3d6949ec78400327ca47995273eba25 = string.Empty;
            this.c9363b2573ec6976255b107de9714a88d = this.c4ccb15ae364b5bb64fd18a538f12488d = this.cbd69662b502356b5738f77fa62d8caa9 = this.c98d2bb12edb2dcd34d12b0d266c30ae4 = this.ce61c1bfa143f12ef54e4723680141300 = AutoBoolean.Auto;
            this.ce01eec33f178a777b002386272adadf9 = this.ccc0f6bd83b90e0c6dad93b05402e740e = this.c0f183e8414cb94885adce81249b7b97b = this.c82fb15376ca8f128e6c409e924aa288f = this.c7c201e0755dc3bdf39293fd8f4ec10a9 = AutoBoolean.Auto;
            this.c00649d7e6c9adb59ef7fd8dacf8c34ae = WizardPageType.Inner;
        }

        protected override void Dispose(bool disposing)
        {
            if (!disposing)
            {
                goto Label_0033;
            }
        Label_0003:
            switch (3)
            {
                case 0:
                    goto Label_0003;

                default:
                    if (1 == 0)
                    {
                    }
                    if (this.c469770157ab2c17cf4bcb42431e5cfe5 == null)
                    {
                        goto Label_0033;
                    }
                    break;
            }
        Label_001E:
            switch (1)
            {
                case 0:
                    goto Label_001E;

                default:
                    this.c469770157ab2c17cf4bcb42431e5cfe5.Dispose();
                    break;
            }
        Label_0033:
            base.Dispose(disposing);
        }

        protected internal virtual void OnAfterHide(EventArgs e)
        {
            if (this.c705e3febeb6f4d93b05016e670f1a73d == null)
            {
                return;
            }
        Label_0008:
            switch (2)
            {
                case 0:
                    goto Label_0008;

                default:
                    if (1 == 0)
                    {
                    }
                    this.c705e3febeb6f4d93b05016e670f1a73d(this, e);
                    break;
            }
        }

        protected internal virtual void OnAfterShow(EventArgs e)
        {
            if (this.c4a4984a2da6e74aaca58d081b737e58b == null)
            {
                return;
            }
        Label_0008:
            switch (1)
            {
                case 0:
                    goto Label_0008;

                default:
                    if (1 == 0)
                    {
                    }
                    this.c4a4984a2da6e74aaca58d081b737e58b(this, e);
                    break;
            }
        }

        protected internal virtual void OnBackButtonClick(WizardPageCancelEventArgs e)
        {
            if (this.cf608572e9306003c3e0ba8e54284f840 != null)
            {
                this.cf608572e9306003c3e0ba8e54284f840(this, e);
            }
        }

        protected internal virtual void OnBeforeHide(WizardPageCancelEventArgs e)
        {
            if (this.c73e4f2e20d6b2343616f4ac408342906 != null)
            {
                this.c73e4f2e20d6b2343616f4ac408342906(this, e);
            }
        }

        protected internal virtual void OnBeforeShow(WizardPageCancelEventArgs e)
        {
            if (this.cd09e3f671d59f7a579ccfe901a8f5f85 == null)
            {
                return;
            }
        Label_0008:
            switch (4)
            {
                case 0:
                    goto Label_0008;

                default:
                    if (1 == 0)
                    {
                    }
                    this.cd09e3f671d59f7a579ccfe901a8f5f85(this, e);
                    break;
            }
        }

        protected internal virtual void OnCancelButtonClick(CancelEventArgs e)
        {
            if (this.c86b33e9d4d2b46d49da06ec1058dfecb == null)
            {
                return;
            }
        Label_0008:
            switch (5)
            {
                case 0:
                    goto Label_0008;

                default:
                    if (1 == 0)
                    {
                    }
                    this.c86b33e9d4d2b46d49da06ec1058dfecb(this, e);
                    break;
            }
        }

        protected internal virtual void OnFinishButtonClick(CancelEventArgs e)
        {
            if (this.c6f82e885b3ff147b92417572eda22e69 == null)
            {
                return;
            }
        Label_0008:
            switch (3)
            {
                case 0:
                    goto Label_0008;

                default:
                    if (1 == 0)
                    {
                    }
                    this.c6f82e885b3ff147b92417572eda22e69(this, e);
                    break;
            }
        }

        protected internal virtual void OnHelpButtonClick(CancelEventArgs e)
        {
            if (this.cf81878b068b3b3d496b7c8529c3b1077 == null)
            {
                return;
            }
        Label_0008:
            switch (6)
            {
                case 0:
                    goto Label_0008;

                default:
                    if (1 == 0)
                    {
                    }
                    this.cf81878b068b3b3d496b7c8529c3b1077(this, e);
                    break;
            }
        }

        protected internal virtual void OnNextButtonClick(WizardPageCancelEventArgs e)
        {
            if (this.c4e6b5a49a342b156ec16f632f3d54132 != null)
            {
                this.c4e6b5a49a342b156ec16f632f3d54132(this, e);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.c1ddc887212aafbd9ba7cb9b75b60e84e != null)
            {
                IWizardPainter painter = this.c1ddc887212aafbd9ba7cb9b75b60e84e.c046b9fcebcde2f879a4f5b27ef7f0d1d();
                Graphics graphics = e.Graphics;
                WizardPaintEventArgs args = new WizardPaintEventArgs(graphics, base.Bounds, this.c1ddc887212aafbd9ba7cb9b75b60e84e, this);
                painter.PaintPage(args);
                return;
            }
        Label_0008:
            switch (5)
            {
                case 0:
                    goto Label_0008;
            }
            if (1 == 0)
            {
            }
        }

        public override string ToString()
        {
            // This item is obfuscated and can not be translated.
            int num1;
            string text3;
            string text1 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x2775);
            string text2 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x278a);
            if (this.c1ddc887212aafbd9ba7cb9b75b60e84e != null)
            {
                goto Label_0047;
            }
        Label_0026:
            switch (5)
            {
                case 0:
                    goto Label_0026;

                default:
                    if (1 != 0)
                    {
                        goto Label_0039;
                    }
                    text3 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x279d);
                    if (text3 || true)
                    {
                        goto Label_0064;
                    }
                    break;
            }
        Label_0047:
            num1 = this.c1ddc887212aafbd9ba7cb9b75b60e84e.cb506ab7cdadec87b67d7e29410151747.IndexOf(this);
            string text4 = num1.ToString();
        Label_0064:
            return (this.c924a7adae948f7734a40ae82ec69a136 + text2 + text3 + text4);
        }

        [Category("WizardPage"), Description("Gets/sets whether the Back button is enabled for the page"), DefaultValue(typeof(AutoBoolean), "Auto")]
        public AutoBoolean BackButtonEnabled
        {
            get
            {
                return this.c9363b2573ec6976255b107de9714a88d;
            }
            set
            {
                if (this.c9363b2573ec6976255b107de9714a88d == value)
                {
                    return;
                }
            Label_0009:
                switch (3)
                {
                    case 0:
                        goto Label_0009;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c9363b2573ec6976255b107de9714a88d = value;
                        if (!this.IsSelected)
                        {
                            return;
                        }
                        break;
                }
            Label_002D:
                switch (5)
                {
                    case 0:
                        goto Label_002D;

                    default:
                        this.c1ddc887212aafbd9ba7cb9b75b60e84e.c3c492d5ebe6640735a90c66472097c21();
                        break;
                }
            }
        }

        [Description("Gets/sets whether the Back button is visible for the page"), Category("WizardPage"), DefaultValue(typeof(AutoBoolean), "Auto")]
        public AutoBoolean BackButtonVisible
        {
            get
            {
                return this.ccc0f6bd83b90e0c6dad93b05402e740e;
            }
            set
            {
                if (this.ccc0f6bd83b90e0c6dad93b05402e740e == value)
                {
                    return;
                }
            Label_0009:
                switch (2)
                {
                    case 0:
                        goto Label_0009;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.ccc0f6bd83b90e0c6dad93b05402e740e = value;
                        if (!this.IsSelected)
                        {
                            return;
                        }
                        break;
                }
            Label_002B:
                switch (5)
                {
                    case 0:
                        goto Label_002B;

                    default:
                        this.c1ddc887212aafbd9ba7cb9b75b60e84e.c3c492d5ebe6640735a90c66472097c21();
                        break;
                }
            }
        }

        [DefaultValue(typeof(AutoBoolean), "Auto"), Description("Gets/sets whether the Cancel button is enabled for the page"), Category("WizardPage")]
        public AutoBoolean CancelButtonEnabled
        {
            get
            {
                return this.ce61c1bfa143f12ef54e4723680141300;
            }
            set
            {
                if (this.ce61c1bfa143f12ef54e4723680141300 != value)
                {
                    this.ce61c1bfa143f12ef54e4723680141300 = value;
                    if (this.IsSelected)
                    {
                        this.c1ddc887212aafbd9ba7cb9b75b60e84e.c3c492d5ebe6640735a90c66472097c21();
                    }
                }
            }
        }

        [Category("WizardPage"), DefaultValue(typeof(AutoBoolean), "Auto"), Description("Gets/sets whether the Cancel button is visible for the page")]
        public AutoBoolean CancelButtonVisible
        {
            get
            {
                return this.c7c201e0755dc3bdf39293fd8f4ec10a9;
            }
            set
            {
                if (this.c7c201e0755dc3bdf39293fd8f4ec10a9 == value)
                {
                    return;
                }
            Label_0009:
                switch (6)
                {
                    case 0:
                        goto Label_0009;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c7c201e0755dc3bdf39293fd8f4ec10a9 = value;
                        if (this.IsSelected)
                        {
                            this.c1ddc887212aafbd9ba7cb9b75b60e84e.c3c492d5ebe6640735a90c66472097c21();
                        }
                        break;
                }
            }
        }

        [DefaultValue("Page caption"), Category("WizardPage"), Description("Gets/sets whether the caption for the page")]
        public string Caption
        {
            get
            {
                return this.c924a7adae948f7734a40ae82ec69a136;
            }
            set
            {
                if (!(this.c924a7adae948f7734a40ae82ec69a136 != value))
                {
                    return;
                }
            Label_0010:
                switch (4)
                {
                    case 0:
                        goto Label_0010;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c924a7adae948f7734a40ae82ec69a136 = value;
                        if (!this.IsSelected)
                        {
                            return;
                        }
                        break;
                }
            Label_0034:
                switch (2)
                {
                    case 0:
                        goto Label_0034;

                    default:
                        this.c1ddc887212aafbd9ba7cb9b75b60e84e.c3c492d5ebe6640735a90c66472097c21();
                        break;
                }
            }
        }

        [DefaultValue("Page description"), Description("Gets/sets the description for the page"), Category("WizardPage")]
        public string Description
        {
            get
            {
                return this.c2bbc876fadd7032d696b137bfa5c2a9c;
            }
            set
            {
                if (!(this.c2bbc876fadd7032d696b137bfa5c2a9c != value))
                {
                    return;
                }
            Label_0010:
                switch (7)
                {
                    case 0:
                        goto Label_0010;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c2bbc876fadd7032d696b137bfa5c2a9c = value;
                        if (!this.IsSelected)
                        {
                            return;
                        }
                        break;
                }
            Label_0032:
                switch (3)
                {
                    case 0:
                        goto Label_0032;

                    default:
                        this.c1ddc887212aafbd9ba7cb9b75b60e84e.c3c492d5ebe6640735a90c66472097c21();
                        break;
                }
            }
        }

        [Category("WizardPage"), DefaultValue(typeof(AutoBoolean), "Auto"), Description("Gets/sets whether the Finish button is enabled for the page")]
        public AutoBoolean FinishButtonEnabled
        {
            get
            {
                return this.cbd69662b502356b5738f77fa62d8caa9;
            }
            set
            {
                if (this.cbd69662b502356b5738f77fa62d8caa9 != value)
                {
                    this.cbd69662b502356b5738f77fa62d8caa9 = value;
                    if (this.IsSelected)
                    {
                        this.c1ddc887212aafbd9ba7cb9b75b60e84e.c3c492d5ebe6640735a90c66472097c21();
                    }
                }
            }
        }

        [DefaultValue(typeof(AutoBoolean), "Auto"), Category("WizardPage"), Description("Gets/sets whether the Finish button is visible for the page")]
        public AutoBoolean FinishButtonVisible
        {
            get
            {
                return this.ce01eec33f178a777b002386272adadf9;
            }
            set
            {
                if (this.ce01eec33f178a777b002386272adadf9 == value)
                {
                    return;
                }
            Label_0009:
                switch (4)
                {
                    case 0:
                        goto Label_0009;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.ce01eec33f178a777b002386272adadf9 = value;
                        if (!this.IsSelected)
                        {
                            return;
                        }
                        break;
                }
            Label_002D:
                switch (1)
                {
                    case 0:
                        goto Label_002D;

                    default:
                        this.c1ddc887212aafbd9ba7cb9b75b60e84e.c3c492d5ebe6640735a90c66472097c21();
                        break;
                }
            }
        }

        [Description("Gets/sets the height in pizels of the page header"), DefaultValue(60), Category("WizardPage")]
        public int HeaderHeight
        {
            get
            {
                return this.c2c722cb7e32a87966531a1e4c598d61d;
            }
            set
            {
                if (this.c2c722cb7e32a87966531a1e4c598d61d == value)
                {
                    return;
                }
                this.c2c722cb7e32a87966531a1e4c598d61d = value;
                if (!this.IsSelected)
                {
                    return;
                }
            Label_001A:
                switch (3)
                {
                    case 0:
                        goto Label_001A;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c1ddc887212aafbd9ba7cb9b75b60e84e.c3c492d5ebe6640735a90c66472097c21();
                        break;
                }
            }
        }

        [Description("Gets/sets the header image for this page"), Category("WizardPage"), DefaultValue((string) null)]
        public Image HeaderImage
        {
            get
            {
                return this.c12a74bd6ba71508a050dd1e73647d36d;
            }
            set
            {
                this.c12a74bd6ba71508a050dd1e73647d36d = value;
                if (this.IsSelected)
                {
                    this.c1ddc887212aafbd9ba7cb9b75b60e84e.c3c492d5ebe6640735a90c66472097c21();
                }
            }
        }

        [Description("Gets/sets whether the page header is visible"), Category("WizardPage"), DefaultValue(typeof(AutoBoolean), "Auto")]
        public AutoBoolean HeaderVisible
        {
            get
            {
                return this.cd0f713933438f34835b01297433a8a7f;
            }
            set
            {
                if (this.cd0f713933438f34835b01297433a8a7f == value)
                {
                    return;
                }
                this.cd0f713933438f34835b01297433a8a7f = value;
                if (!this.IsSelected)
                {
                    return;
                }
            Label_001A:
                switch (4)
                {
                    case 0:
                        goto Label_001A;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c1ddc887212aafbd9ba7cb9b75b60e84e.c3c492d5ebe6640735a90c66472097c21();
                        break;
                }
            }
        }

        [Description("Gets/sets whether the Help button is enabled for the page"), Category("WizardPage"), DefaultValue(typeof(AutoBoolean), "Auto")]
        public AutoBoolean HelpButtonEnabled
        {
            get
            {
                return this.c98d2bb12edb2dcd34d12b0d266c30ae4;
            }
            set
            {
                if (this.c98d2bb12edb2dcd34d12b0d266c30ae4 == value)
                {
                    return;
                }
            Label_0009:
                switch (2)
                {
                    case 0:
                        goto Label_0009;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98d2bb12edb2dcd34d12b0d266c30ae4 = value;
                        if (!this.IsSelected)
                        {
                            return;
                        }
                        break;
                }
            Label_002D:
                switch (4)
                {
                    case 0:
                        goto Label_002D;

                    default:
                        this.c1ddc887212aafbd9ba7cb9b75b60e84e.c3c492d5ebe6640735a90c66472097c21();
                        break;
                }
            }
        }

        [DefaultValue(typeof(AutoBoolean), "Auto"), Description("Gets/sets whether the Help button is visible for the page"), Category("WizardPage")]
        public AutoBoolean HelpButtonVisible
        {
            get
            {
                return this.c82fb15376ca8f128e6c409e924aa288f;
            }
            set
            {
                if (this.c82fb15376ca8f128e6c409e924aa288f == value)
                {
                    return;
                }
            Label_0009:
                switch (7)
                {
                    case 0:
                        goto Label_0009;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c82fb15376ca8f128e6c409e924aa288f = value;
                        if (!this.IsSelected)
                        {
                            return;
                        }
                        break;
                }
            Label_002D:
                switch (6)
                {
                    case 0:
                        goto Label_002D;

                    default:
                        this.c1ddc887212aafbd9ba7cb9b75b60e84e.c3c492d5ebe6640735a90c66472097c21();
                        break;
                }
            }
        }

        [DefaultValue(""), Category("WizardPage"), Description("Gets/sets the caption of the host form when this page is selected")]
        public string HostFormCaption
        {
            get
            {
                return this.cc3d6949ec78400327ca47995273eba25;
            }
            set
            {
                this.cc3d6949ec78400327ca47995273eba25 = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false), Description("Gets the index of the page in the collection")]
        public int Index
        {
            get
            {
                if (this.c1ddc887212aafbd9ba7cb9b75b60e84e != null)
                {
                    return this.c1ddc887212aafbd9ba7cb9b75b60e84e.cb506ab7cdadec87b67d7e29410151747.IndexOf(this);
                }
            Label_0008:
                switch (3)
                {
                    case 0:
                        goto Label_0008;
                }
                if (1 == 0)
                {
                }
                return -1;
            }
        }

        [Browsable(false)]
        public bool IsSelected
        {
            get
            {
                if (this.c1ddc887212aafbd9ba7cb9b75b60e84e != null)
                {
                    return (this.c1ddc887212aafbd9ba7cb9b75b60e84e.c670e475d239cb644a7575b20d9ccf630 == this);
                }
            Label_0008:
                switch (3)
                {
                    case 0:
                        goto Label_0008;
                }
                if (1 == 0)
                {
                }
                return false;
            }
        }

        [Description("Gets/sets whether the Next button is enabled for the page"), DefaultValue(typeof(AutoBoolean), "Auto"), Category("WizardPage")]
        public AutoBoolean NextButtonEnabled
        {
            get
            {
                return this.c4ccb15ae364b5bb64fd18a538f12488d;
            }
            set
            {
                if (this.c4ccb15ae364b5bb64fd18a538f12488d == value)
                {
                    return;
                }
            Label_0009:
                switch (1)
                {
                    case 0:
                        goto Label_0009;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c4ccb15ae364b5bb64fd18a538f12488d = value;
                        if (!this.IsSelected)
                        {
                            return;
                        }
                        break;
                }
            Label_002D:
                switch (5)
                {
                    case 0:
                        goto Label_002D;

                    default:
                        this.c1ddc887212aafbd9ba7cb9b75b60e84e.c3c492d5ebe6640735a90c66472097c21();
                        break;
                }
            }
        }

        [DefaultValue(typeof(AutoBoolean), "Auto"), Description("Gets/sets whether the Next button is visible for the page"), Category("WizardPage")]
        public AutoBoolean NextButtonVisible
        {
            get
            {
                return this.c0f183e8414cb94885adce81249b7b97b;
            }
            set
            {
                if (this.c0f183e8414cb94885adce81249b7b97b == value)
                {
                    return;
                }
            Label_0009:
                switch (3)
                {
                    case 0:
                        goto Label_0009;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c0f183e8414cb94885adce81249b7b97b = value;
                        if (this.IsSelected)
                        {
                            this.c1ddc887212aafbd9ba7cb9b75b60e84e.c3c492d5ebe6640735a90c66472097c21();
                        }
                        break;
                }
            }
        }

        [Category("WizardPage"), Description("Gets/sets the type of the page (Welcome/Inner/Finish)"), DefaultValue(typeof(WizardPageType), "Inner")]
        public WizardPageType PageType
        {
            get
            {
                return this.c00649d7e6c9adb59ef7fd8dacf8c34ae;
            }
            set
            {
                if (this.c00649d7e6c9adb59ef7fd8dacf8c34ae == value)
                {
                    return;
                }
            Label_0009:
                switch (2)
                {
                    case 0:
                        goto Label_0009;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c00649d7e6c9adb59ef7fd8dacf8c34ae = value;
                        if (!this.IsSelected)
                        {
                            return;
                        }
                        break;
                }
            Label_002D:
                switch (1)
                {
                    case 0:
                        goto Label_002D;

                    default:
                        this.c1ddc887212aafbd9ba7cb9b75b60e84e.c3c492d5ebe6640735a90c66472097c21();
                        break;
                }
            }
        }

        [Description("Gets/sets the painter which will paint the wizard when this page is the selected page"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IWizardPainter Painter
        {
            get
            {
                return this.c6e26ff980e0b200f1325323b389d13c3;
            }
            set
            {
                if (this.c6e26ff980e0b200f1325323b389d13c3 == value)
                {
                    return;
                }
            Label_0009:
                switch (4)
                {
                    case 0:
                        goto Label_0009;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c6e26ff980e0b200f1325323b389d13c3 = value;
                        if (this.c1ddc887212aafbd9ba7cb9b75b60e84e != null)
                        {
                            this.c1ddc887212aafbd9ba7cb9b75b60e84e.Invalidate();
                        }
                        break;
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false), Description("Gets the wizard to which this page belongs")]
        public LogicNP.ShellObjects.Wizard Wizard
        {
            get
            {
                return this.c1ddc887212aafbd9ba7cb9b75b60e84e;
            }
        }
    }
}

