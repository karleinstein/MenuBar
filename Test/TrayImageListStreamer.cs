namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.Collections;
    using System.Drawing;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Runtime.Serialization;

    [Serializable]
    public class TrayImageListStreamer : ISerializable
    {
        internal ArrayList lstImages;
        internal Color tClr;
        internal TrayImageList trayImageList;

        public TrayImageListStreamer(TrayImageList trayImageList)
        {
            this.trayImageList = trayImageList;
            this.lstImages = null;
        }

        public TrayImageListStreamer(SerializationInfo i, StreamingContext c)
        {
            string name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(1);
            object obj4 = i.GetValue(name, typeof(int));
            int num = (int) obj4;
            Color color2 = ColorTranslator.FromWin32(num);
            this.tClr = color2;
            this.lstImages = new ArrayList();
            string text7 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(12);
            int num2 = i.GetInt32(text7);
            for (int j = 0; j < num2; j++)
            {
                string text8 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x21);
                string text9 = j.ToString();
                string text10 = text8 + text9;
                Type type = typeof(byte[]);
                object obj2 = i.GetValue(text10, type);
                this.lstImages.Add(obj2);
            }
        Label_0098:
            switch (4)
            {
                case 0:
                    goto Label_0098;
            }
            if (1 == 0)
            {
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                if (this.trayImageList == null)
                {
                    goto Label_012D;
                }
            Label_000B:
                switch (6)
                {
                    case 0:
                        goto Label_000B;

                    default:
                    {
                        if (1 == 0)
                        {
                        }
                        string text8 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(1);
                        info.AddValue(text8, this.trayImageList.c86b9294fa317bc153018374ee90a6fa8.c43e113a305e15c4fb96d407f389976bc);
                        int num = this.trayImageList.c86b9294fa317bc153018374ee90a6fa8.c6fb6c993aa193eb2510ab09a7268db89();
                        info.AddValue(c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(12), num);
                        for (int j = 0; j < this.trayImageList.c86b9294fa317bc153018374ee90a6fa8.c6fb6c993aa193eb2510ab09a7268db89(); j++)
                        {
                            ce683794939d915f7ff47e2a37d21f7f4 cedfffeadff;
                            IntPtr ptr = this.trayImageList.c86b9294fa317bc153018374ee90a6fa8.c1c92a2218e8d52d1ae361e18a8018671(j);
                            c5001fc25b22c764c441dbd96c957460f cfcbccdbdcf = null;
                            cedfffeadff = new ce683794939d915f7ff47e2a37d21f7f4 {
                                ce0fa64280702b562ec88d57b9547e766 = Marshal.SizeOf(cedfffeadff),
                                cd7a8106fe4c6dea439f6991aab7bdeb7 = 1,
                                c6a37c739d8a621a2416ebb4c1c15cf1d = ptr
                            };
                            cfcbccdbdcf = c1f3ac373189b87d6dcb629efcbe8286b.c286ba22439de868f21db617a0316b016(cedfffeadff, ref c1f3ac373189b87d6dcb629efcbe8286b.c2887a36300b2bb4aa9ac680aa1369828, false);
                            cbbfa5270c9aa502deaef9d176c843fce cbbfacaadeaefdcfce = null;
                            cbbfacaadeaefdcfce = cfcbccdbdcf as cbbfa5270c9aa502deaef9d176c843fce;
                            byte[] buffer = new byte[(int) cbbfacaadeaefdcfce.c62f13ad7dff2806ec3a48d2e11f49cb6()];
                            cfcedf6504f851bff600c57c3416bb4f6 cfcedffbffccbbf = new cfcedf6504f851bff600c57c3416bb4f6(new MemoryStream(buffer));
                            cbbfacaadeaefdcfce.c8770dcc55bfb6eee23bf2a8b89cbeeb0(cfcedffbffccbbf, true);
                            cfcedffbffccbbf.c421c8421da70f1345519d2e49fb6e99d();
                            string text9 = j.ToString();
                            string text10 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x21) + text9;
                            info.AddValue(text10, buffer);
                            cbbfacaadeaefdcfce = null;
                            cfcbccdbdcf = null;
                        }
                        return;
                    }
                }
            Label_012D:
                if (this.lstImages == null)
                {
                    return;
                }
            Label_0138:
                switch (6)
                {
                    case 0:
                        goto Label_0138;
                }
                string name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(1);
                int num7 = ColorTranslator.ToWin32(this.tClr);
                info.AddValue(name, num7);
                int num4 = this.lstImages.Count;
                info.AddValue(c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(12), num4);
                for (int i = 0; i < num4; i++)
                {
                    string text12 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x21);
                    string text13 = i.ToString();
                    string text14 = text12 + text13;
                    object obj3 = this.lstImages[i];
                    info.AddValue(text14, obj3);
                }
            }
            catch
            {
            }
        }
    }
}

