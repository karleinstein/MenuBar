namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    [TypeConverter(typeof(c59625fe086289688bdc89143a0bc9835))]
    public class ResizerSettings
    {
        internal double c0a1e41fae2b968610a1b9c635835529c;
        internal int c10b0d428736b571cc7f50d19430bda6e;
        internal ControlResizeSettings c26cecf4775971b3dcd61f354863296df;
        internal float c37a9a2fb5b837df826ae100769632d47;
        internal static ControlResizeSettings c43a64d1e90bff4efca2edef8326f91bf = ControlResizeSettings.All;
        internal Resizer c6e1168351c09e3079747e64fef1d930c;
        internal double c797d1406cb8c7842b21a1ec291f1c83a;
        internal float c8196f7fc37ffefdcfe8cdbacfefc3a70;
        internal int c918009801080aac07877fc923033decc;
        internal Control c92ec88d675c52bc1fd9422d4e4032352;
        internal int c9c2eb72cb1f08184dbb274648706afcf;
        internal double cab6aa8793019378e8ba1e5609d4095dd;
        internal double cb162a8cb7d5530812f1d2374c2e0c0ac;
        internal int ce480f2a771a2094e329c89817f17e90f;

        public ResizerSettings()
        {
            this.c26cecf4775971b3dcd61f354863296df = c43a64d1e90bff4efca2edef8326f91bf;
            this.c918009801080aac07877fc923033decc = -1;
            this.c9c2eb72cb1f08184dbb274648706afcf = -1;
            this.c10b0d428736b571cc7f50d19430bda6e = -1;
            this.ce480f2a771a2094e329c89817f17e90f = -1;
            this.c8196f7fc37ffefdcfe8cdbacfefc3a70 = -1f;
        }

        internal ResizerSettings(Resizer c6e1168351c09e3079747e64fef1d930c, Control c92ec88d675c52bc1fd9422d4e4032352) : this()
        {
            this.c6e1168351c09e3079747e64fef1d930c = c6e1168351c09e3079747e64fef1d930c;
            this.c92ec88d675c52bc1fd9422d4e4032352 = c92ec88d675c52bc1fd9422d4e4032352;
        }

        internal static bool c071ede0ae116ddf5f7c966ba7d201efe(ControlResizeSettings c26cecf4775971b3dcd61f354863296df)
        {
            return ((c26cecf4775971b3dcd61f354863296df & ControlResizeSettings.Height) != ControlResizeSettings.None);
        }

        internal void c1b9178604090d5221df9c979f066d0a1()
        {
            this.c918009801080aac07877fc923033decc = this.c92ec88d675c52bc1fd9422d4e4032352.Height;
            int width = this.c92ec88d675c52bc1fd9422d4e4032352.Width;
            this.ce480f2a771a2094e329c89817f17e90f = width;
            this.c10b0d428736b571cc7f50d19430bda6e = this.c92ec88d675c52bc1fd9422d4e4032352.Top;
            int left = this.c92ec88d675c52bc1fd9422d4e4032352.Left;
            this.c9c2eb72cb1f08184dbb274648706afcf = left;
            float sizeInPoints = this.c92ec88d675c52bc1fd9422d4e4032352.Font.SizeInPoints;
            this.c8196f7fc37ffefdcfe8cdbacfefc3a70 = sizeInPoints;
        }

        internal void c30291f00ac534ce920cf0179a9b57aa8()
        {
            Font font3;
            int num11;
            int num8;
            if (this.c92ec88d675c52bc1fd9422d4e4032352.Height == this.c918009801080aac07877fc923033decc)
            {
                goto Label_0046;
            }
        Label_0013:
            switch (5)
            {
                case 0:
                    goto Label_0013;

                default:
                {
                    if (1 == 0)
                    {
                    }
                    int height = this.c92ec88d675c52bc1fd9422d4e4032352.Height;
                    this.cb162a8cb7d5530812f1d2374c2e0c0ac = ((double) height) / this.c6e1168351c09e3079747e64fef1d930c.cc5dde2ecb98aba24816981c499c8a9bf;
                    break;
                }
            }
        Label_0046:
            num8 = this.c92ec88d675c52bc1fd9422d4e4032352.Width;
            if (num8 != this.ce480f2a771a2094e329c89817f17e90f)
            {
                int width = this.c92ec88d675c52bc1fd9422d4e4032352.Width;
                this.c797d1406cb8c7842b21a1ec291f1c83a = ((double) width) / this.c6e1168351c09e3079747e64fef1d930c.cba12be90625ab675d5d106a3fad8e441;
            }
            if (this.c92ec88d675c52bc1fd9422d4e4032352.Top == this.c10b0d428736b571cc7f50d19430bda6e)
            {
                goto Label_00B8;
            }
        Label_008E:
            switch (1)
            {
                case 0:
                    goto Label_008E;

                default:
                {
                    int top = this.c92ec88d675c52bc1fd9422d4e4032352.Top;
                    this.c0a1e41fae2b968610a1b9c635835529c = ((double) top) / this.c6e1168351c09e3079747e64fef1d930c.cc5dde2ecb98aba24816981c499c8a9bf;
                    break;
                }
            }
        Label_00B8:
            num11 = this.c92ec88d675c52bc1fd9422d4e4032352.Left;
            if (num11 == this.c9c2eb72cb1f08184dbb274648706afcf)
            {
                goto Label_00F7;
            }
        Label_00CD:
            switch (5)
            {
                case 0:
                    goto Label_00CD;

                default:
                {
                    int left = this.c92ec88d675c52bc1fd9422d4e4032352.Left;
                    this.cab6aa8793019378e8ba1e5609d4095dd = ((double) left) / this.c6e1168351c09e3079747e64fef1d930c.cba12be90625ab675d5d106a3fad8e441;
                    break;
                }
            }
        Label_00F7:
            font3 = this.c92ec88d675c52bc1fd9422d4e4032352.Font;
            if (font3.SizeInPoints != this.c8196f7fc37ffefdcfe8cdbacfefc3a70)
            {
                Font font = this.c92ec88d675c52bc1fd9422d4e4032352.Font;
                float sizeInPoints = font.SizeInPoints;
                this.c37a9a2fb5b837df826ae100769632d47 = sizeInPoints / this.c6e1168351c09e3079747e64fef1d930c.c212fb0c987b10b58bd5ad28e5c083848;
            }
        }

        internal static bool c423c9f1dc061750d18108abbee957a9e(ControlResizeSettings c26cecf4775971b3dcd61f354863296df)
        {
            return ((c26cecf4775971b3dcd61f354863296df & ControlResizeSettings.Top) != ControlResizeSettings.None);
        }

        internal bool c53e5e0832fb83636ff0dda6ff8211b95()
        {
            return this.ShouldSerializeSettings();
        }

        internal static bool c78ee242687d153a9b230d62aaa546202(ControlResizeSettings c26cecf4775971b3dcd61f354863296df)
        {
            return ((c26cecf4775971b3dcd61f354863296df & ControlResizeSettings.Left) != ControlResizeSettings.None);
        }

        internal static bool cbe0bcba68c332f2c73336c87b00b3a86(ControlResizeSettings c26cecf4775971b3dcd61f354863296df)
        {
            return ((c26cecf4775971b3dcd61f354863296df & ControlResizeSettings.All) != ControlResizeSettings.None);
        }

        internal static bool cbe96c3489cbcecf7758c85a6b1547e36(ControlResizeSettings c26cecf4775971b3dcd61f354863296df)
        {
            return ((c26cecf4775971b3dcd61f354863296df & ControlResizeSettings.Font) != ControlResizeSettings.None);
        }

        internal void ccef4e49327327d2fb4ba685c83816060()
        {
            double num10 = Math.Round((double) (this.c6e1168351c09e3079747e64fef1d930c.ca2c8e8ca465a003d3ba5e1a59b9a0cae * this.cb162a8cb7d5530812f1d2374c2e0c0ac));
            int num = (int) num10;
            double num11 = Math.Round((double) (this.c6e1168351c09e3079747e64fef1d930c.c1b3a2cfa804b6c224c7d96add98d5924 * this.c797d1406cb8c7842b21a1ec291f1c83a));
            int num2 = (int) num11;
            double num12 = Math.Round((double) (this.c6e1168351c09e3079747e64fef1d930c.ca2c8e8ca465a003d3ba5e1a59b9a0cae * this.c0a1e41fae2b968610a1b9c635835529c));
            int num3 = (int) num12;
            double num13 = Math.Round((double) (this.c6e1168351c09e3079747e64fef1d930c.c1b3a2cfa804b6c224c7d96add98d5924 * this.cab6aa8793019378e8ba1e5609d4095dd));
            int num4 = (int) num13;
            float num5 = this.c6e1168351c09e3079747e64fef1d930c.ce57a1f6c17313c6239d748e38dc22262 * this.c37a9a2fb5b837df826ae100769632d47;
            ControlResizeSettings settings = this.c26cecf4775971b3dcd61f354863296df;
            ControlResizeEventArgs e = new ControlResizeEventArgs(this.c92ec88d675c52bc1fd9422d4e4032352, num4, num3, num2, num, num5, this.c26cecf4775971b3dcd61f354863296df);
            this.c6e1168351c09e3079747e64fef1d930c.OnControlResize(e);
            num4 = e.cd03c605e2371c81d7acc5ae7a1f02fed;
            num3 = e.cba5e657701b90ff0aacc637f0d245bed;
            num2 = e.cd316589d318cf6f1091a8bedc6543c26;
            num = e.c0f0b8dd499e68cef6658dcebaf96c6c7;
            num5 = e.c16da6b67f2080cf3857158047d4e8ef8;
            settings = e.c9c2069cd91149a4be8fad8867a7cbde3;
            if (!cbe0bcba68c332f2c73336c87b00b3a86(settings))
            {
                return;
            }
            if (num >= 0)
            {
                goto Label_0109;
            }
        Label_00F4:
            switch (6)
            {
                case 0:
                    goto Label_00F4;

                default:
                    if (1 == 0)
                    {
                    }
                    num = 0;
                    break;
            }
        Label_0109:
            if (num2 >= 0)
            {
                goto Label_0119;
            }
        Label_010D:
            switch (5)
            {
                case 0:
                    goto Label_010D;

                default:
                    num2 = 0;
                    break;
            }
        Label_0119:
            if (num5 > 0f)
            {
                goto Label_0133;
            }
        Label_0122:
            switch (5)
            {
                case 0:
                    goto Label_0122;

                default:
                    num5 = 1f;
                    break;
            }
        Label_0133:
            if (!c78ee242687d153a9b230d62aaa546202(settings))
            {
                goto Label_0154;
            }
        Label_013E:
            switch (3)
            {
                case 0:
                    goto Label_013E;

                default:
                    this.c92ec88d675c52bc1fd9422d4e4032352.Left = num4;
                    break;
            }
        Label_0154:
            if (cd7264c8433d15e139e0e4ccda9173bc4(settings))
            {
                this.c92ec88d675c52bc1fd9422d4e4032352.Width = num2;
            }
            if (!c423c9f1dc061750d18108abbee957a9e(settings))
            {
                goto Label_018C;
            }
        Label_0176:
            switch (3)
            {
                case 0:
                    goto Label_0176;

                default:
                    this.c92ec88d675c52bc1fd9422d4e4032352.Top = num3;
                    break;
            }
        Label_018C:
            if (!c071ede0ae116ddf5f7c966ba7d201efe(settings))
            {
                goto Label_01AB;
            }
        Label_0195:
            switch (2)
            {
                case 0:
                    goto Label_0195;

                default:
                    this.c92ec88d675c52bc1fd9422d4e4032352.Height = num;
                    break;
            }
        Label_01AB:
            if (cbe96c3489cbcecf7758c85a6b1547e36(settings))
            {
                Font font = this.c92ec88d675c52bc1fd9422d4e4032352.Font;
                FontFamily fontFamily = font.FontFamily;
                Font font4 = this.c92ec88d675c52bc1fd9422d4e4032352.Font;
                this.c92ec88d675c52bc1fd9422d4e4032352.Font = new Font(fontFamily, num5, font4.Style);
            }
            if (!ce817b0b70eeeadab7ca29e44931b0bff(settings))
            {
                return;
            }
        Label_01F5:
            switch (1)
            {
                case 0:
                    goto Label_01F5;

                default:
                {
                    Control.ControlCollection controls = this.c92ec88d675c52bc1fd9422d4e4032352.Controls;
                    if (controls.Count <= 0)
                    {
                        return;
                    }
                    break;
                }
            }
        Label_0216:
            switch (1)
            {
                case 0:
                    goto Label_0216;

                default:
                    if (!(this.c92ec88d675c52bc1fd9422d4e4032352 is UserControl) & !(this.c92ec88d675c52bc1fd9422d4e4032352 is Form))
                    {
                        this.c6e1168351c09e3079747e64fef1d930c.cb877c343a04f6cbb1998a5d0e8d44c4a(this.c92ec88d675c52bc1fd9422d4e4032352);
                    }
                    break;
            }
        }

        internal static bool cd7264c8433d15e139e0e4ccda9173bc4(ControlResizeSettings c26cecf4775971b3dcd61f354863296df)
        {
            return ((c26cecf4775971b3dcd61f354863296df & ControlResizeSettings.Width) != ControlResizeSettings.None);
        }

        internal void cdea8e251fb8b9e76f808d81e27175ebb()
        {
            this.ResetSettings();
        }

        internal static bool ce817b0b70eeeadab7ca29e44931b0bff(ControlResizeSettings c26cecf4775971b3dcd61f354863296df)
        {
            return ((c26cecf4775971b3dcd61f354863296df & ControlResizeSettings.Children) != ControlResizeSettings.None);
        }

        public void ResetSettings()
        {
            this.Settings = c43a64d1e90bff4efca2edef8326f91bf;
        }

        public bool ShouldSerializeSettings()
        {
            return (this.c26cecf4775971b3dcd61f354863296df != c43a64d1e90bff4efca2edef8326f91bf);
        }

        public ControlResizeSettings Settings
        {
            get
            {
                return this.c26cecf4775971b3dcd61f354863296df;
            }
            set
            {
                this.c26cecf4775971b3dcd61f354863296df = value;
            }
        }
    }
}

