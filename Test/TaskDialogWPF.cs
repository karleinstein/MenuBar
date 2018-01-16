namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Design;
    using System.IO;
    using System.Reflection;
    using System.Windows;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    [Description("Display Vista 'task dialog' style message boxes."), LicenseProvider(typeof(c8501506cd6fad4aa5297d71ae6dcee33))]
    public class TaskDialogWPF : FrameworkElement
    {
        private c9f3e51e839cf41991f6e84afc4c0b030 c7ff050d39cb2d26403eca2ee39bdd6bf = new c9f3e51e839cf41991f6e84afc4c0b030();

        public event EventHandler AfterConstruct
        {
            add
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.cb56601e15edada5f76d83f6373391a58 += value;
            }
            remove
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.cb56601e15edada5f76d83f6373391a58 -= value;
            }
        }

        public event EventHandler BeforeDestroy
        {
            add
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c33b1cb9af94f6d18ea2df12f37832982 += value;
            }
            remove
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c33b1cb9af94f6d18ea2df12f37832982 -= value;
            }
        }

        public event EventHandler BeforeShow
        {
            add
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.cd09e3f671d59f7a579ccfe901a8f5f85 += value;
            }
            remove
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.cd09e3f671d59f7a579ccfe901a8f5f85 -= value;
            }
        }

        public event TaskDialogButtonClickEventHandler ButtonClick
        {
            add
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c1e642669951a50baa1c3fae906a3d844 += value;
            }
            remove
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c1e642669951a50baa1c3fae906a3d844 -= value;
            }
        }

        public event TaskDialogCheckboxCheckEventHandler CheckboxCheck
        {
            add
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.cd7427f64d4d45e021008b67fb6c8cc1e += value;
            }
            remove
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.cd7427f64d4d45e021008b67fb6c8cc1e -= value;
            }
        }

        public event TaskDialogExpandoControlClickEventHandler ExpandoControlClick
        {
            add
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.ca0d0d2d7ddf6be0f20375df6f3e94c83 += value;
            }
            remove
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.ca0d0d2d7ddf6be0f20375df6f3e94c83 -= value;
            }
        }

        public event EventHandler HelpRequested
        {
            add
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.cf18c33067540060b124ab468effbf19a += value;
            }
            remove
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.cf18c33067540060b124ab468effbf19a -= value;
            }
        }

        public event TaskDialogHyperLinkClickEventHandler HyperLinkClick
        {
            add
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c3d82f9c821b14404c8a81734b90237b4 += value;
            }
            remove
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c3d82f9c821b14404c8a81734b90237b4 -= value;
            }
        }

        public event TaskDialogRadioButtonClickEventHandler RadioButtonClick
        {
            add
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c1edaaa2c99dc47baae2f704ef9072f37 += value;
            }
            remove
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c1edaaa2c99dc47baae2f704ef9072f37 -= value;
            }
        }

        public event TaskDialogTimerTickEventHandler TimerTick
        {
            add
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.ca4cd7d187ba265f4b0b04dde01ff1cfa += value;
            }
            remove
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.ca4cd7d187ba265f4b0b04dde01ff1cfa -= value;
            }
        }

        public TaskDialogWPF()
        {
            Type type = typeof(TaskDialogWPF);
            License license1 = LicenseManager.Validate(type, this);
            base.Visibility = Visibility.Hidden;
        }

        public int GetClickedButtonID()
        {
            return this.c7ff050d39cb2d26403eca2ee39bdd6bf.cc52a9522035d290b229bf5a25ad33bf2();
        }

        public int GetSelectedRadioButtonID()
        {
            return this.c7ff050d39cb2d26403eca2ee39bdd6bf.c5427567f8326b07c37f6cc2a42656399();
        }

        public bool IsCheckBoxChecked()
        {
            return this.c7ff050d39cb2d26403eca2ee39bdd6bf.c42bd95b6a932ecedfaedfc9b80fa5ae0();
        }

        protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize)
        {
            return new System.Windows.Size(16.0, 16.0);
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            string name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x27f3);
            Stream stream = executingAssembly.GetManifestResourceStream(name);
            BitmapImage imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.StreamSource = stream;
            imageSource.EndInit();
            Rect rectangle = new Rect(0.0, 0.0, 16.0, 16.0);
            drawingContext.DrawImage(imageSource, rectangle);
            base.OnRender(drawingContext);
        }

        public void PerformButtonClick(int btnID)
        {
            this.c7ff050d39cb2d26403eca2ee39bdd6bf.ca77c86c978ed6031ccc39f4918dc1b57(btnID);
        }

        public void PerformRadioButtonClick(int btnID)
        {
            this.c7ff050d39cb2d26403eca2ee39bdd6bf.cea71e928bffb2c57fd9297de1c9c0985(btnID);
        }

        public void Show()
        {
            this.c7ff050d39cb2d26403eca2ee39bdd6bf.cca5c5131ff5751053c5c296e97a1967f();
        }

        public void SwitchToTaskDialog(TaskDialogWPF newTaskDialog)
        {
            this.c7ff050d39cb2d26403eca2ee39bdd6bf.c414e9e046942b7e13684725bd569d715(newTaskDialog.c7ff050d39cb2d26403eca2ee39bdd6bf);
        }

        [Category("TaskDialog Properties"), DefaultValue(true), Description(""), Browsable(true)]
        public bool AllowDialogCancellation
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.ce595ef1da9271eb14aeb69a6bce56445;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.ce595ef1da9271eb14aeb69a6bce56445 = value;
            }
        }

        [Browsable(true), Category("TaskDialog Properties"), DefaultValue(true), Description("")]
        public bool CanBeMinimised
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.c19e7de93cbdc98ef0b4b69d7c08cbcbd;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c19e7de93cbdc98ef0b4b69d7c08cbcbd = value;
            }
        }

        [Description(""), DefaultValue(false), Category("TaskDialog Properties"), Browsable(true)]
        public bool CheckBoxChecked
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.cdec1678812ce3b69eaf0889cf88cfbae;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.cdec1678812ce3b69eaf0889cf88cfbae = value;
            }
        }

        [Description("Gets or sets the verifaication checkbox text of the window"), Browsable(true), Category("TaskDialog Properties"), DefaultValue("CheckBox Text")]
        public string CheckBoxText
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.c0875d22ac757005f2cd839e4acdc953a;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c0875d22ac757005f2cd839e4acdc953a = value;
            }
        }

        [DefaultValue("true"), Description("Gets or sets whether checkbox text should be shown"), Browsable(true), Category("TaskDialog Properties")]
        public bool CheckBoxVisible
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.ca6aefa18f34ab6595d64f3eb64963036;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.ca6aefa18f34ab6595d64f3eb64963036 = value;
            }
        }

        [Description(""), Category("TaskDialog Properties"), Editor(typeof(c826e1947054dc132ce73d91387ff2197), typeof(UITypeEditor)), Browsable(true)]
        public TaskDialogCommonButtons CommonButtons
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.c4d4ea2853da3dc1e425c13c1de85d36a;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c4d4ea2853da3dc1e425c13c1de85d36a = value;
            }
        }

        [Browsable(true), Category("TaskDialog Properties"), Description("Gets or sets the content of the window"), DefaultValue("ContentText")]
        public string ContentText
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.c3417f986eed3c6b0a7ace114f18e1f7a;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c3417f986eed3c6b0a7ace114f18e1f7a = value;
            }
        }

        [Description(""), Category("TaskDialog Properties"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(true)]
        public TaskDialogButtonList CustomButtons
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.c3bce31daa1eee81e5fe3f9b27016e5a6;
            }
        }

        [Category("TaskDialog Properties"), DefaultValue(1), Browsable(true), Description("")]
        public TaskDialogCustomButtonStyle CustomButtonStyle
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.c295c9f6958df415ea9a71221f3cd24f4;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c295c9f6958df415ea9a71221f3cd24f4 = value;
            }
        }

        [Browsable(true), Category("TaskDialog Properties"), Description("")]
        public int DefaultButtonID
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.cfc3f1041c5eb8490106fd01cd4148efd;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.cfc3f1041c5eb8490106fd01cd4148efd = value;
            }
        }

        [Category("TaskDialog Properties"), Description(""), Browsable(true)]
        public int DefaultRadioButtonID
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.c42b71f1a7559891eab07082685b8444f;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c42b71f1a7559891eab07082685b8444f = value;
            }
        }

        [Description(""), Browsable(true), DefaultValue(true), Category("TaskDialog Properties")]
        public bool EnableHyperLinks
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.cd431dcc026666fe7eab42c0b5d358596;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.cd431dcc026666fe7eab42c0b5d358596 = value;
            }
        }

        [Browsable(true), Description(""), Category("TaskDialog Properties"), DefaultValue(true)]
        public bool EnableTimer
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.c641eb705f44739c4458df50375013e99;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c641eb705f44739c4458df50375013e99 = value;
            }
        }

        [Browsable(true), Description("Gets or sets the  text of the expanded window"), DefaultValue("Expanded Text"), Category("TaskDialog Properties")]
        public string ExpandedText
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.cda2b7c1e7e046941e1f74e6173378a88;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.cda2b7c1e7e046941e1f74e6173378a88 = value;
            }
        }

        [Description(""), Browsable(true), DefaultValue(1), Category("TaskDialog Properties")]
        public TaskDialogExpandedTextPosition ExpandedTextPosition
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.c36d048cabd9cba6cf4efca740afffbce;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c36d048cabd9cba6cf4efca740afffbce = value;
            }
        }

        [Description("Gets or sets the  text of the collapsed control on the window"), Browsable(true), DefaultValue(""), Category("TaskDialog Properties")]
        public string ExpandoControlCollapsedText
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.caaef551eeb3022dd2bda3cc935b60631;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.caaef551eeb3022dd2bda3cc935b60631 = value;
            }
        }

        [Browsable(true), Category("TaskDialog Properties"), Description("Gets or sets the  text of the expanded control on the window"), DefaultValue("")]
        public string ExpandoControlExpandedText
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.c4f7b713abd27fde073a454714509c910;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c4f7b713abd27fde073a454714509c910 = value;
            }
        }

        [Category("TaskDialog Properties"), Description(""), DefaultValue(2), Browsable(true)]
        public TaskDialogExpandoControlState ExpandoControlState
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.c0bd4fe5b5cc7c5f051e79af9f1b70a5e;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c0bd4fe5b5cc7c5f051e79af9f1b70a5e = value;
            }
        }

        [DefaultValue(""), Browsable(true), Category("TaskDialog Properties"), Description("Gets or sets whether expanded control should be shown")]
        public bool ExpandoControlVisible
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.c96f16b4d616381330b61ddec238d156b;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c96f16b4d616381330b61ddec238d156b = value;
            }
        }

        [Browsable(true), Category("TaskDialog Properties"), Description("")]
        public Icon FooterIcon
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.c6813fac14223b68bcd246d17d98d23c7;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c6813fac14223b68bcd246d17d98d23c7 = value;
            }
        }

        [Description(""), DefaultValue(-3), Browsable(true), Category("TaskDialog Properties")]
        public TaskDialogIconType FooterIconType
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.c312505ef219736f97849c1298ea43eee;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c312505ef219736f97849c1298ea43eee = value;
            }
        }

        [Description("Gets or sets the  text of the Footer on the window"), DefaultValue("Footer Text"), Category("TaskDialog Properties"), Browsable(true)]
        public string FooterText
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.c088c37934cb538c7044438383f054253;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c088c37934cb538c7044438383f054253 = value;
            }
        }

        [Browsable(false)]
        public IntPtr Handle
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.ce1938124994d2f4f8134f0d7e4155f7c;
            }
        }

        [Browsable(false)]
        public bool IsShown
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.c48c36b4fb6c5dd7c1596932596d5ddea;
            }
        }

        [Browsable(true), Description(""), Category("TaskDialog Properties")]
        public Icon MainIcon
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.cb8dfd79963a4b6401f933649a2909db1;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.cb8dfd79963a4b6401f933649a2909db1 = value;
            }
        }

        [Description(""), Category("TaskDialog Properties"), DefaultValue(-3), Browsable(true)]
        public TaskDialogIconType MainIconType
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.cf10b5b8b38de4536a5966fabcae0e185;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.cf10b5b8b38de4536a5966fabcae0e185 = value;
            }
        }

        [Browsable(true), DefaultValue("Main Text"), Description("Gets or sets the main instruction"), Category("TaskDialog Properties")]
        public string MainText
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.cbb59ee9fffed3fd20870882bdd869d05;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.cbb59ee9fffed3fd20870882bdd869d05 = value;
            }
        }

        [Description(""), Browsable(true), DefaultValue(500), Category("TaskDialog Properties")]
        public int ProgressBarMarqueeSpeed
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.c4b4b8f8725ccbd1c2418be97c5897b13;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c4b4b8f8725ccbd1c2418be97c5897b13 = value;
            }
        }

        [Category("TaskDialog Properties"), Browsable(true), DefaultValue(0), Description("")]
        public int ProgressBarValueCurrent
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.cbac3d59f62c437594a8a9c01677a9d98;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.cbac3d59f62c437594a8a9c01677a9d98 = value;
            }
        }

        [DefaultValue(100), Description(""), Category("TaskDialog Properties"), Browsable(true)]
        public int ProgressBarValueMax
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.cab75d74f95516c2d7d255b2305833a42;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.cab75d74f95516c2d7d255b2305833a42 = value;
            }
        }

        [DefaultValue(0), Category("TaskDialog Properties"), Description(""), Browsable(true)]
        public int ProgressBarValueMin
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.ca934bebfa839eae0f987a7a01b27c944;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.ca934bebfa839eae0f987a7a01b27c944 = value;
            }
        }

        [Browsable(true), Category("TaskDialog Properties"), DefaultValue(1), Description("")]
        public ProgressBarStyle ProgressBarViewStyle
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.c939c7aa92a870496a6f3f8190164414e;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.c939c7aa92a870496a6f3f8190164414e = value;
            }
        }

        [Browsable(true), Category("TaskDialog Properties"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Description("")]
        public TaskDialogButtonList RadioButtons
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.cbd6f43197cc939b1bb31ed669c7542cf;
            }
        }

        [Description(""), Category("TaskDialog Properties"), DefaultValue(false), Browsable(true)]
        public bool RTLLayout
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.cfca6fb955be73eeaec599aad69bebfe0;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.cfca6fb955be73eeaec599aad69bebfe0 = value;
            }
        }

        [DefaultValue("Title Text"), Description("Gets or sets the title of the window"), Category("TaskDialog Properties"), Browsable(true)]
        public string TitleText
        {
            get
            {
                return this.c7ff050d39cb2d26403eca2ee39bdd6bf.cc6f3cb835d070a7863c2c8a82c9498e0;
            }
            set
            {
                this.c7ff050d39cb2d26403eca2ee39bdd6bf.cc6f3cb835d070a7863c2c8a82c9498e0 = value;
            }
        }
    }
}

