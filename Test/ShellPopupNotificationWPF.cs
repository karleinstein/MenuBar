namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Reflection;
    using System.Windows;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    [LicenseProvider(typeof(c8501506cd6fad4aa5297d71ae6dcee33)), Description("Display multiple MSN/Office2003 style popups.")]
    public class ShellPopupNotificationWPF : FrameworkElement
    {
        private c55fc859b2ef86cbc2bc9830b6d750078 c17a89cb933522b68193cba2637134a5f = new c55fc859b2ef86cbc2bc9830b6d750078();

        [Description("Occurs after a popup notification is closed."), Category("ShellPopupNotification Properties")]
        public event ShellPopupEventHandler AfterClose
        {
            add
            {
                this.c17a89cb933522b68193cba2637134a5f.cf890687200e5bb5fe15823fe51f5e6e3 += value;
            }
            remove
            {
                this.c17a89cb933522b68193cba2637134a5f.cf890687200e5bb5fe15823fe51f5e6e3 -= value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Occurs after a popup notification is fully shown.")]
        public event ShellPopupEventHandler AfterPopup
        {
            add
            {
                this.c17a89cb933522b68193cba2637134a5f.cd86612242c3bc124acf1ebfa66063eea += value;
            }
            remove
            {
                this.c17a89cb933522b68193cba2637134a5f.cd86612242c3bc124acf1ebfa66063eea -= value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Occurs before a popup notification is about to be closed.")]
        public event ShellPopupEventHandler BeforeClose
        {
            add
            {
                this.c17a89cb933522b68193cba2637134a5f.c59ae1e6cd8eb6279d6df3969728cc1d5 += value;
            }
            remove
            {
                this.c17a89cb933522b68193cba2637134a5f.c59ae1e6cd8eb6279d6df3969728cc1d5 -= value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Occurs before a popup notification is shown.")]
        public event ShellPopupEventHandler BeforePopup
        {
            add
            {
                this.c17a89cb933522b68193cba2637134a5f.c876283055f2f38a0d4bfc2c7e866b474 += value;
            }
            remove
            {
                this.c17a89cb933522b68193cba2637134a5f.c876283055f2f38a0d4bfc2c7e866b474 -= value;
            }
        }

        [Description("Occurs when the close button of a popup notification is clicked."), Category("ShellPopupNotification Properties")]
        public event ShellPopupCancelEventHandler CloseButtonClick
        {
            add
            {
                this.c17a89cb933522b68193cba2637134a5f.ca11548a5d349644d9ebb9d05bb8b07e0 += value;
            }
            remove
            {
                this.c17a89cb933522b68193cba2637134a5f.ca11548a5d349644d9ebb9d05bb8b07e0 -= value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Occurs after a context menu item is selected.")]
        public event ShellPopupContextMenuItemEventHandler ContextMenuItemSelect
        {
            add
            {
                this.c17a89cb933522b68193cba2637134a5f.c7e81ee978c75e5ea366a521aa3772c23 += value;
            }
            remove
            {
                this.c17a89cb933522b68193cba2637134a5f.c7e81ee978c75e5ea366a521aa3772c23 -= value;
            }
        }

        [Description("Occurs before a context menu is displayed in response to calling the InvokeContextMenu method."), Category("ShellPopupNotification Properties")]
        public event ShellPopupContextMenuEventHandler ContextMenuPopup
        {
            add
            {
                this.c17a89cb933522b68193cba2637134a5f.c169886752dfeac9efc4e8fef9209ac6e += value;
            }
            remove
            {
                this.c17a89cb933522b68193cba2637134a5f.c169886752dfeac9efc4e8fef9209ac6e -= value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Occurs after the link of a popup notification is clicked.")]
        public event ShellPopupEventHandler LinkClick
        {
            add
            {
                this.c17a89cb933522b68193cba2637134a5f.cc566348ff1f609942a8ffdf4240f0aa2 += value;
            }
            remove
            {
                this.c17a89cb933522b68193cba2637134a5f.cc566348ff1f609942a8ffdf4240f0aa2 -= value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Occurs when a mouse button is pressed over a popup notification.")]
        public event ShellPopupMouseEventHandler MouseDown
        {
            add
            {
                this.c17a89cb933522b68193cba2637134a5f.c3e9fce08aea72fc8f20909a9b5740d65 += value;
            }
            remove
            {
                this.c17a89cb933522b68193cba2637134a5f.c3e9fce08aea72fc8f20909a9b5740d65 -= value;
            }
        }

        [Description("Occurs when the mouse moves over a popup notification."), Category("ShellPopupNotification Properties")]
        public event ShellPopupMouseEventHandler MouseMove
        {
            add
            {
                this.c17a89cb933522b68193cba2637134a5f.c5372488ecc0ee5982ccdd2ad0fc2e55b += value;
            }
            remove
            {
                this.c17a89cb933522b68193cba2637134a5f.c5372488ecc0ee5982ccdd2ad0fc2e55b -= value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Occurs when a mouse button is released over a popup notification.")]
        public event ShellPopupMouseEventHandler MouseUp
        {
            add
            {
                this.c17a89cb933522b68193cba2637134a5f.ca2fc7dd3008742530fda8571b04a827c += value;
            }
            remove
            {
                this.c17a89cb933522b68193cba2637134a5f.ca2fc7dd3008742530fda8571b04a827c -= value;
            }
        }

        [Description("Occurs after the options button of a popup notification is clicked."), Category("ShellPopupNotification Properties")]
        public event ShellPopupEventHandler OptionsButtonClick
        {
            add
            {
                this.c17a89cb933522b68193cba2637134a5f.c8d3b5728b5a7bd4dfa5e295a0a186335 += value;
            }
            remove
            {
                this.c17a89cb933522b68193cba2637134a5f.c8d3b5728b5a7bd4dfa5e295a0a186335 -= value;
            }
        }

        [Description("Occurs after the text of a popup notification is clicked."), Category("ShellPopupNotification Properties")]
        public event ShellPopupEventHandler TextClick
        {
            add
            {
                this.c17a89cb933522b68193cba2637134a5f.c5e3dd6962c2147883ae4db45648ef94c += value;
            }
            remove
            {
                this.c17a89cb933522b68193cba2637134a5f.c5e3dd6962c2147883ae4db45648ef94c -= value;
            }
        }

        [Description("Display multiple MSN/Office2003 style popups.")]
        public ShellPopupNotificationWPF()
        {
            Type type = typeof(ShellPopupNotificationWPF);
            License license1 = LicenseManager.Validate(type, this);
            base.Visibility = Visibility.Hidden;
        }

        [Description("Creates a new popup notification.")]
        public ShellPopup CreatePopup()
        {
            return this.c17a89cb933522b68193cba2637134a5f.ccf9838936f58705a79177fa57b2bce94();
        }

        protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize)
        {
            return new System.Windows.Size(16.0, 16.0);
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            string name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x25ad);
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
            BitmapImage imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.StreamSource = stream;
            imageSource.EndInit();
            Rect rectangle = new Rect(0.0, 0.0, 16.0, 16.0);
            drawingContext.DrawImage(imageSource, rectangle);
            base.OnRender(drawingContext);
        }

        [Description("Creates and shows a new popup notification.")]
        public ShellPopup ShowPopup()
        {
            return this.c17a89cb933522b68193cba2637134a5f.c09e524e8fe6497eb638d0d0fda3929fb();
        }

        [Category("ShellPopupNotification Properties"), DefaultValue(0x7d0), Description("Gets or sets the time duration in milliseconds that popup notifications are shown before they are automatically closed.")]
        public int ActiveShowTime
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c1af25e645336795e4dc97dc8412f29ea;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c1af25e645336795e4dc97dc8412f29ea = value;
            }
        }

        [Category("ShellPopupNotification Properties"), DefaultValue(typeof(bool), "true"), Description("Gets or sets whether popup notifications can be dragged by the gripper bar in Office2003 style.")]
        public bool AllowDrag
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c10715b234af603cb6566a6fb84f7b8c8;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c10715b234af603cb6566a6fb84f7b8c8 = value;
            }
        }

        [DefaultValue(typeof(AnimStyles), "Slide"), Category("ShellPopupNotification Properties"), Description("Gets or sets the animation style used to show popup notifications.")]
        public AnimStyles AnimationStyle
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c8983e54e60d2740caa1289513605652a;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c8983e54e60d2740caa1289513605652a = value;
            }
        }

        [DefaultValue(600), Description("Gets or sets the time duration of the animation used for popup notifications."), Category("ShellPopupNotification Properties")]
        public int AnimTime
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.ca61cbcaafaa13ce534caee0a855b650f;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.ca61cbcaafaa13ce534caee0a855b650f = value;
            }
        }

        [DefaultValue(170), Description("Gets or sets the height of popup notifications when automatic positioning is used."), Category("ShellPopupNotification Properties")]
        public int AutoPopupHeight
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.cb28682dc4bbb6e7eea38d9a6db2c355e;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.cb28682dc4bbb6e7eea38d9a6db2c355e = value;
            }
        }

        [Description("Gets or sets the width of popup notifications when automatic positioning is used."), DefaultValue(170), Category("ShellPopupNotification Properties")]
        public int AutoPopupWidth
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.ccdf1bcf3686555190ea6de1dc4079ee3;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.ccdf1bcf3686555190ea6de1dc4079ee3 = value;
            }
        }

        [Category("ShellPopupNotification Properties"), DefaultValue(typeof(AutoPositioningDirections), "Auto"), Description("Gets or sets how multiple popup notifications are shown when automatic positioning is used.")]
        public AutoPositioningDirections AutoPositioningDirection
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c3fda5869d1703d876c8c149efdd47a69;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c3fda5869d1703d876c8c149efdd47a69 = value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Gets or sets the back color of popup notifications.")]
        public System.Drawing.Color BackColor
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.cc8f2ac0f6f4409551f72feaeb448b795;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.cc8f2ac0f6f4409551f72feaeb448b795 = value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Gets or sets the second back color of popup notifications, used when gradient or hatch fill styles are specified.")]
        public System.Drawing.Color BackColor2
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c815432e71926feee78d9fe2562842b88;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c815432e71926feee78d9fe2562842b88 = value;
            }
        }

        [Description("Gets or sets the background fill style of popup notifications."), Category("ShellPopupNotification Properties")]
        public FillStyles BackFillStyle
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c75b7ea048ff758bb4e77331830af1186;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c75b7ea048ff758bb4e77331830af1186 = value;
            }
        }

        [Description("Gets or sets the gradient style of popup notifications."), Category("ShellPopupNotification Properties")]
        public GradientModes BackGradientMode
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c1e9304138dc0e722ad6d6e610a481b78;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c1e9304138dc0e722ad6d6e610a481b78 = value;
            }
        }

        [Description("Gets or sets the hatch style of popup notifications."), Category("ShellPopupNotification Properties")]
        public HatchStyles BackHatchStyle
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.cf130e8190a571973c1cb53f82eb3d51a;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.cf130e8190a571973c1cb53f82eb3d51a = value;
            }
        }

        [Category("ShellPopupNotification Properties"), DefaultValue(typeof(Bitmap), "null"), Description("Gets or sets the background image shown in popup notifications.")]
        public Bitmap BackImage
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c5946ee9504c4e44420a88535a86062c2;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c5946ee9504c4e44420a88535a86062c2 = value;
            }
        }

        [DefaultValue(typeof(HAlignments), "Center"), Description("Gets or sets the horizontal alignment of the background image of popup notifications."), Category("ShellPopupNotification Properties")]
        public HAlignments BackImageHAlign
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c2b5d1f8b54d1749cfce91a033560a003;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c2b5d1f8b54d1749cfce91a033560a003 = value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Gets or sets whether the background image of popup notifications is drawn transparently."), DefaultValue(typeof(bool), "true")]
        public bool BackImageIsTransparent
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c271d2c504f46cace1803aeb5e070b7af;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c271d2c504f46cace1803aeb5e070b7af = value;
            }
        }

        [Description("Gets or sets the transparent color of the background image of popup notifications."), DefaultValue(typeof(System.Drawing.Color), "Black"), Category("ShellPopupNotification Properties")]
        public System.Drawing.Color BackImageTransparentColor
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.cc2a373469e1bec0a79040bb22942ced5;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.cc2a373469e1bec0a79040bb22942ced5 = value;
            }
        }

        [Category("ShellPopupNotification Properties"), DefaultValue(typeof(VAlignments), "Center"), Description("Gets or sets the vertical alignment of the background image of popup notifications.")]
        public VAlignments BackImageVAlign
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.ca4f72b482b2fe148ccae4642322ec8d3;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.ca4f72b482b2fe148ccae4642322ec8d3 = value;
            }
        }

        [Description("Gets or sets the border color of popup notifications."), Category("ShellPopupNotification Properties")]
        public System.Drawing.Color BorderColor
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.cb626d371f24b084b9c3ec8e541c8b851;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.cb626d371f24b084b9c3ec8e541c8b851 = value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Gets or sets the second border color of popup notifications, used when a 3D border style is specified.")]
        public System.Drawing.Color BorderColor3D
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c2a8f25212cd0decf4f90ce230de4e663;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c2a8f25212cd0decf4f90ce230de4e663 = value;
            }
        }

        [Description("Gets or sets the border style of popup notifications."), Category("ShellPopupNotification Properties")]
        public BorderStyles BorderStyle
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.ca8710af2a947ea339ce47e594ab81d84;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.ca8710af2a947ea339ce47e594ab81d84 = value;
            }
        }

        [Category("ShellPopupNotification Properties"), DefaultValue(170), Description("Gets or sets the width of popup notifications when custom positioning is used.")]
        public int CustomPopupHeight
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c343bc4da37224683fad8b4ba3674fea1;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c343bc4da37224683fad8b4ba3674fea1 = value;
            }
        }

        [Category("ShellPopupNotification Properties"), DefaultValue(100), Description("Gets or sets the left position of popup notifications when custom positioning is used.")]
        public int CustomPopupLeft
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c73e3337382b2f13c42aa43be7f082c10;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c73e3337382b2f13c42aa43be7f082c10 = value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Gets or sets the top position of popup notifications when custom positioning is used."), DefaultValue(100)]
        public int CustomPopupTop
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c0b4f856c6f1e29c6e6c5971910f1cc8f;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c0b4f856c6f1e29c6e6c5971910f1cc8f = value;
            }
        }

        [Description("Gets or sets the width of popup notifications when custom positioning is used."), Category("ShellPopupNotification Properties"), DefaultValue(170)]
        public int CustomPopupWidth
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c31b3be6d2f54476cab201a11ca832939;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c31b3be6d2f54476cab201a11ca832939 = value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Gets or sets the gripper color of popup notifications.")]
        public System.Drawing.Color GripperColor
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c62e9a3cc70a958e0764721c50c761b6a;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c62e9a3cc70a958e0764721c50c761b6a = value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Gets or sets the second gripper color of popup notifications.")]
        public System.Drawing.Color GripperColor2
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c17090586352f3cd6b22d1bab7be8a795;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c17090586352f3cd6b22d1bab7be8a795 = value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Gets or sets the gradient style used for grippers.")]
        public GradientModes GripperGradientMode
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c3576a78aa5201d6c2c0004068bf85a29;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c3576a78aa5201d6c2c0004068bf85a29 = value;
            }
        }

        [Description("Gets or sets the link color of popup notifications."), Category("ShellPopupNotification Properties")]
        public System.Drawing.Color LinkColor
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.ce6594bda76f5e6d4bb1be45ce0916b20;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.ce6594bda76f5e6d4bb1be45ce0916b20 = value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Gets or sets the hot-state link color of popup notifications.")]
        public System.Drawing.Color LinkColorHot
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.ce76d7f627fd2266f805c3f6e3a292248;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.ce76d7f627fd2266f805c3f6e3a292248 = value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Gets or sets the font name of the link of popup notifications.")]
        public string LinkFontName
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c3b9a7ce0a2a2d28ac914819c9a5b7909;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c3b9a7ce0a2a2d28ac914819c9a5b7909 = value;
            }
        }

        [Description("Gets or sets the font size of the link of popup notifications."), Category("ShellPopupNotification Properties")]
        public int LinkFontSize
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c75e83884560827b7b7479747410d62d3;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c75e83884560827b7b7479747410d62d3 = value;
            }
        }

        [Description("Gets or sets the font style of the link of popup notifications."), Category("ShellPopupNotification Properties")]
        public LogicNP.ShellObjects.FontStyles LinkFontStyle
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c505d2908e693140ce7e7b755ed980bae;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c505d2908e693140ce7e7b755ed980bae = value;
            }
        }

        [Description("Gets or sets the font style of the hot-state link of popup notifications."), Category("ShellPopupNotification Properties")]
        public LogicNP.ShellObjects.FontStyles LinkFontStyleHot
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c2d667d5e790adea3c1658bad496b70fb;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c2d667d5e790adea3c1658bad496b70fb = value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Gets or sets the horizontal alignment of the link of popup notifications.")]
        public HAlignments LinkHAlign
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c8346b519abe1e625f9fd0d95d60317a4;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c8346b519abe1e625f9fd0d95d60317a4 = value;
            }
        }

        [Description("Gets or sets the link text shown in popup notifications."), Category("ShellPopupNotification Properties"), DefaultValue("")]
        public string LinkString
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c2e33172340dbb2d69f0c538d104ca271;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c2e33172340dbb2d69f0c538d104ca271 = value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Gets or sets the vertical alignment of the link of popup notifications.")]
        public VAlignments LinkVAlign
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c3ef0392d1a5698330506c8ef3c86000c;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c3ef0392d1a5698330506c8ef3c86000c = value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Gets or sets the logo image of popup notifications."), DefaultValue(typeof(Bitmap), "null")]
        public Bitmap LogoImage
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c051e7515f22ec34b5966e347e11a14fb;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c051e7515f22ec34b5966e347e11a14fb = value;
            }
        }

        [Category("ShellPopupNotification Properties"), DefaultValue(typeof(HAlignments), "Left"), Description("Gets or sets the horizontal alignment of the logo image of popup notifications.")]
        public HAlignments LogoImageHAlign
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c3a533a1b5a4c21c3bf994457e9d753ef;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c3a533a1b5a4c21c3bf994457e9d753ef = value;
            }
        }

        [Description("Gets or sets whether the logo image of popup notifications is drawn transparently"), DefaultValue(typeof(bool), "true"), Category("ShellPopupNotification Properties")]
        public bool LogoImageIsTransparent
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c5f0fc5f5a9a1f1d4de278793d27b7bc6;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c5f0fc5f5a9a1f1d4de278793d27b7bc6 = value;
            }
        }

        [Category("ShellPopupNotification Properties"), DefaultValue(typeof(System.Drawing.Color), "Black"), Description("Gets or sets the transparent color of the logo image of popup notifications.")]
        public System.Drawing.Color LogoImageTransparentColor
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c2440cf2b2b281a911330ec60c2ed061c;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c2440cf2b2b281a911330ec60c2ed061c = value;
            }
        }

        [Category("ShellPopupNotification Properties"), DefaultValue(typeof(VAlignments), "Top"), Description("Gets or sets the vertical alignment of the logo image of popup notifications.")]
        public VAlignments LogoImageVAlign
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c2599a3c93d1d343b0341deb7cf3b2cb4;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c2599a3c93d1d343b0341deb7cf3b2cb4 = value;
            }
        }

        [DefaultValue(0xff), Description("Gets or sets the maximum opacity of popup notifications when they are fully shown."), Category("ShellPopupNotification Properties")]
        public int MaxOpacity
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c4dcc581d77a6f6ce2d575957c1374af7;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c4dcc581d77a6f6ce2d575957c1374af7 = value;
            }
        }

        [DefaultValue(typeof(PositioningStyles), "Auto"), Description("Gets or sets whether popup notifications are automatically positioned or they used custom position coordinates."), Category("ShellPopupNotification Properties")]
        public PositioningStyles PositioningStyle
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.ce99bc511ac6fe12614cf4bcecc54f989;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.ce99bc511ac6fe12614cf4bcecc54f989 = value;
            }
        }

        [DefaultValue(typeof(bool), "true"), Description("Gets or sets whether the close button is shown in popup notifications."), Category("ShellPopupNotification Properties")]
        public bool ShowCloseButton
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c62f407b9d36feabbb035f29199ef68af;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c62f407b9d36feabbb035f29199ef68af = value;
            }
        }

        [DefaultValue(typeof(bool), "false"), Category("ShellPopupNotification Properties"), Description("Gets or sets whether the options button is shown in popup notifications.")]
        public bool ShowOptionsButton
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.cdd1b20a109cd55bf5593fc4fe7a4598f;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.cdd1b20a109cd55bf5593fc4fe7a4598f = value;
            }
        }

        [DefaultValue(typeof(SlideStyles), "Default"), Category("ShellPopupNotification Properties"), Description("Gets or sets the slide style used for animating popup notifications.")]
        public SlideStyles SlideStyle
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.cdd08894b1c634e5c6ab38c4c105f6d4c;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.cdd08894b1c634e5c6ab38c4c105f6d4c = value;
            }
        }

        [Description("Gets or sets the sound that is played when a popup is shown"), Category("ShellPopupNotification Properties"), DefaultValue("SystemNotification")]
        public string SoundFile
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c8fcbb6c680f64a8ecbdd103d9b4cc5b7;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c8fcbb6c680f64a8ecbdd103d9b4cc5b7 = value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Gets or sets the text color of popup notifications.")]
        public System.Drawing.Color TextColor
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.cf00878866d49044254a8ee1f3a626863;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.cf00878866d49044254a8ee1f3a626863 = value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Gets or sets the hot-state text color of popup notifications.")]
        public System.Drawing.Color TextColorHot
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c858f515f0a6ae6b3196f0bf4c7557f1a;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c858f515f0a6ae6b3196f0bf4c7557f1a = value;
            }
        }

        [Description("Gets or sets the font name of the text of popup notifications."), Category("ShellPopupNotification Properties")]
        public string TextFontName
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c7f0ccf6c278b21eac9ec56560d3dfa85;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c7f0ccf6c278b21eac9ec56560d3dfa85 = value;
            }
        }

        [Description("Gets or sets the font size of the text of popup notifications."), Category("ShellPopupNotification Properties")]
        public int TextFontSize
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.ceae0e99db2eefbc637f086c856b6ba82;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.ceae0e99db2eefbc637f086c856b6ba82 = value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Gets or sets the font style of the text of popup notifications.")]
        public LogicNP.ShellObjects.FontStyles TextFontStyle
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.cb1da61e580b37825f3befabecb27b911;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.cb1da61e580b37825f3befabecb27b911 = value;
            }
        }

        [Description("Gets or sets the font style of the hot-state text of popup notifications."), Category("ShellPopupNotification Properties")]
        public LogicNP.ShellObjects.FontStyles TextFontStyleHot
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c8746458f5b6243f52dc31cdd564b7570;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c8746458f5b6243f52dc31cdd564b7570 = value;
            }
        }

        [Description("Gets or sets the horizontal alignment of the text of popup notifications."), Category("ShellPopupNotification Properties")]
        public HAlignments TextHAlign
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c9f0c6e85fd305810c650cc8ae5352fdc;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c9f0c6e85fd305810c650cc8ae5352fdc = value;
            }
        }

        [Category("ShellPopupNotification Properties"), DefaultValue("LogicNP Software Shell Popup Notification"), Description("Gets or sets the text shown in popup notifications.")]
        public string TextString
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.cff11f5ead4b2e60f201c2f56c06f6aed;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.cff11f5ead4b2e60f201c2f56c06f6aed = value;
            }
        }

        [Category("ShellPopupNotification Properties"), Description("Gets or sets the vertical alignment of the text of popup notifications.")]
        public VAlignments TextVAlign
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c5fb94640caeb3651afd67edfe70774de;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c5fb94640caeb3651afd67edfe70774de = value;
            }
        }

        [DefaultValue(typeof(VisualStyles), "MSN"), Description("Gets or sets the visual style of popup notifications."), Category("ShellPopupNotification Properties")]
        public VisualStyles VisualStyle
        {
            get
            {
                return this.c17a89cb933522b68193cba2637134a5f.c60898910de4a8f78f1f02e870b752156;
            }
            set
            {
                this.c17a89cb933522b68193cba2637134a5f.c60898910de4a8f78f1f02e870b752156 = value;
            }
        }
    }
}

