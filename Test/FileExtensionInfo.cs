namespace LogicNP.ShellObjects
{
    using A;
    using Microsoft.Win32;
    using System;
    using System.Collections;

    public class FileExtensionInfo
    {
        internal static LogicNP.ShellObjects.RootKey c3c8f2bf05792b7cd91c3874f2546562e = LogicNP.ShellObjects.RootKey.CurrentUser;
        private string c6841b04665eadf0932430e047cc1ee47;
        internal static RegistryKey c9d74ceff2b19d6749de77f39b66900bd = null;
        internal const string ce854bd4493cbfa5e387a1dd24321a442 = "Specified file extension does not exist in the registry";

        static FileExtensionInfo()
        {
            if (c9d74ceff2b19d6749de77f39b66900bd != null)
            {
                return;
            }
        Label_0013:
            switch (1)
            {
                case 0:
                    goto Label_0013;

                default:
                    if (1 == 0)
                    {
                    }
                    RootKey = LogicNP.ShellObjects.RootKey.ClassesRoot;
                    break;
            }
        }

        public FileExtensionInfo(string extension)
        {
            this.c6841b04665eadf0932430e047cc1ee47 = extension;
        }

        private RegistryKey c1906723b69187bca5edf3bb0555b852b()
        {
            try
            {
                return c9d74ceff2b19d6749de77f39b66900bd.OpenSubKey(this.c6841b04665eadf0932430e047cc1ee47, false);
            }
            catch
            {
            }
            return null;
        }

        private void c26bac9c381b9d1d7731bdf7631a63129(string cfb2f2abc8e61232ab9b3563c7fc6acf6)
        {
            RegistryKey key = null;
            try
            {
                key = this.c72cd30bd3eb9f70f50575427861911e3();
                if (key == null)
                {
                    throw new InvalidOperationException(c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x2181));
                }
                key.SetValue(string.Empty, cfb2f2abc8e61232ab9b3563c7fc6acf6);
                cce833f06f74ce72fd6c2fddde19f6f65();
            }
            catch
            {
            }
            finally
            {
                if (key == null)
                {
                    goto Label_0050;
                }
            Label_0037:
                switch (2)
                {
                    case 0:
                        goto Label_0037;

                    default:
                        if (1 == 0)
                        {
                        }
                        key.Close();
                        break;
                }
            Label_0050:;
            }
        }

        private void c6225bf0f4b7b2cf556ba4d925e2b1a89(string cfb2f2abc8e61232ab9b3563c7fc6acf6)
        {
            RegistryKey key = null;
            try
            {
                key = this.c72cd30bd3eb9f70f50575427861911e3();
                if (key == null)
                {
                    string message = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x2181);
                    throw new InvalidOperationException(message);
                }
                string name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x21f0);
                key.SetValue(name, cfb2f2abc8e61232ab9b3563c7fc6acf6);
                cce833f06f74ce72fd6c2fddde19f6f65();
            }
            catch
            {
            }
            finally
            {
                if (key == null)
                {
                    goto Label_005B;
                }
            Label_0042:
                switch (4)
                {
                    case 0:
                        goto Label_0042;

                    default:
                        if (1 == 0)
                        {
                        }
                        key.Close();
                        break;
                }
            Label_005B:;
            }
        }

        private RegistryKey c72cd30bd3eb9f70f50575427861911e3()
        {
            try
            {
                return c9d74ceff2b19d6749de77f39b66900bd.CreateSubKey(this.c6841b04665eadf0932430e047cc1ee47);
            }
            catch
            {
            }
            return null;
        }

        private string c89bad68a2f9ec5e950b5fc65c3d2b6fa()
        {
            RegistryKey key = null;
            try
            {
                string text4;
                key = this.c1906723b69187bca5edf3bb0555b852b();
                if (key != null)
                {
                    goto Label_0033;
                }
            Label_000E:
                switch (4)
                {
                    case 0:
                        goto Label_000E;

                    default:
                    {
                        if (1 == 0)
                        {
                        }
                        string message = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x2181);
                        throw new InvalidOperationException(message);
                    }
                }
            Label_0033:
                text4 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x2209);
                object obj2 = key.GetValue(text4);
                if (obj2 == null)
                {
                    goto Label_0074;
                }
                string str = obj2 as string;
                if (str == null)
                {
                    goto Label_0074;
                }
            Label_0055:
                switch (2)
                {
                    case 0:
                        goto Label_0055;
                }
                return str;
            }
            catch
            {
            }
            finally
            {
                if (key != null)
                {
                    key.Close();
                }
            }
        Label_0074:
            return string.Empty;
        }

        private void c8efc793cbf642eef3ebcdf032c5db030(string cfb2f2abc8e61232ab9b3563c7fc6acf6)
        {
            RegistryKey key = null;
            try
            {
                key = this.c72cd30bd3eb9f70f50575427861911e3();
                if (key == null)
                {
                    string message = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x2181);
                    throw new InvalidOperationException(message);
                }
                string name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x2209);
                key.SetValue(name, cfb2f2abc8e61232ab9b3563c7fc6acf6);
                cce833f06f74ce72fd6c2fddde19f6f65();
            }
            catch
            {
            }
            finally
            {
                if (key == null)
                {
                    goto Label_005B;
                }
            Label_0042:
                switch (6)
                {
                    case 0:
                        goto Label_0042;

                    default:
                        if (1 == 0)
                        {
                        }
                        key.Close();
                        break;
                }
            Label_005B:;
            }
        }

        private string c945a85930e3864fffbc129cc5d793b4b()
        {
            RegistryKey key = null;
            try
            {
                string text4;
                string str;
                key = this.c1906723b69187bca5edf3bb0555b852b();
                if (key != null)
                {
                    goto Label_0033;
                }
            Label_000E:
                switch (5)
                {
                    case 0:
                        goto Label_000E;

                    default:
                    {
                        if (1 == 0)
                        {
                        }
                        string message = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x2181);
                        throw new InvalidOperationException(message);
                    }
                }
            Label_0033:
                text4 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x21f0);
                object obj2 = key.GetValue(text4);
                if (obj2 == null)
                {
                    goto Label_0088;
                }
            Label_004B:
                switch (1)
                {
                    case 0:
                        goto Label_004B;

                    default:
                        str = obj2 as string;
                        if (str == null)
                        {
                            goto Label_0088;
                        }
                        break;
                }
            Label_005F:
                switch (3)
                {
                    case 0:
                        goto Label_005F;
                }
                return str;
            }
            catch
            {
            }
            finally
            {
                if (key == null)
                {
                    goto Label_0087;
                }
            Label_0077:
                switch (5)
                {
                    case 0:
                        goto Label_0077;

                    default:
                        key.Close();
                        break;
                }
            Label_0087:;
            }
        Label_0088:
            return string.Empty;
        }

        internal static void cce833f06f74ce72fd6c2fddde19f6f65()
        {
            c1f3ac373189b87d6dcb629efcbe8286b.ce4ba91cae7358f2ec7be2be722ea80e5(0x8000000, 0x2000, IntPtr.Zero, IntPtr.Zero);
        }

        private string cdab27b76fe5fa1adfec65b69c23df481()
        {
            RegistryKey key = null;
            try
            {
                object obj4;
                key = this.c1906723b69187bca5edf3bb0555b852b();
                if (key != null)
                {
                    goto Label_0031;
                }
            Label_000E:
                switch (1)
                {
                    case 0:
                        goto Label_000E;

                    default:
                        if (1 == 0)
                        {
                        }
                        throw new InvalidOperationException(c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x2181));
                }
            Label_0031:
                obj4 = key.GetValue(string.Empty);
                object obj2 = obj4;
                if (obj2 == null)
                {
                    goto Label_0075;
                }
            Label_0042:
                switch (2)
                {
                    case 0:
                        goto Label_0042;
                }
                string str = obj2 as string;
                if (str != null)
                {
                    return str;
                }
            }
            catch
            {
            }
            finally
            {
                if (key == null)
                {
                    goto Label_0074;
                }
            Label_0064:
                switch (3)
                {
                    case 0:
                        goto Label_0064;

                    default:
                        key.Close();
                        break;
                }
            Label_0074:;
            }
        Label_0075:
            return string.Empty;
        }

        public bool Delete()
        {
            try
            {
                c9d74ceff2b19d6749de77f39b66900bd.DeleteSubKeyTree(this.c6841b04665eadf0932430e047cc1ee47);
                return true;
            }
            catch
            {
            }
            return false;
        }

        public static FileExtensionInfo[] GetFileExtensionInfoList()
        {
            ArrayList list = new ArrayList();
            try
            {
                foreach (string str in c9d74ceff2b19d6749de77f39b66900bd.GetSubKeyNames())
                {
                    string text2 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x217e);
                    if (!str.StartsWith(text2))
                    {
                        continue;
                    }
                Label_0033:
                    switch (5)
                    {
                        case 0:
                            goto Label_0033;

                        default:
                            if (1 == 0)
                            {
                            }
                            list.Add(new FileExtensionInfo(str));
                            break;
                    }
                }
            Label_0060:
                switch (4)
                {
                    case 0:
                        goto Label_0060;
                }
            }
            catch
            {
            }
            Type type = typeof(FileExtensionInfo);
            return (FileExtensionInfo[]) list.ToArray(type);
        }

        public ProgIDInfo GetProgIDInfo(bool autoCreate)
        {
            try
            {
                string str = this.ProgID;
                if (str == null)
                {
                    goto Label_0033;
                }
            Label_000C:
                switch (3)
                {
                    case 0:
                        goto Label_000C;

                    default:
                        if (1 == 0)
                        {
                        }
                        if (str.Length != 0)
                        {
                            return new ProgIDInfo(str);
                        }
                        break;
                }
            Label_0029:
                switch (5)
                {
                    case 0:
                        goto Label_0029;
                }
            Label_0033:
                if (autoCreate)
                {
                    string text7 = this.c6841b04665eadf0932430e047cc1ee47.Trim(new char[] { '.' });
                    string text8 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x2224);
                    string text9 = text7 + text8;
                    this.ProgID = text9;
                    return new ProgIDInfo(this.ProgID);
                }
            }
            catch
            {
            }
            return null;
        }

        public string ContentType
        {
            get
            {
                return this.c945a85930e3864fffbc129cc5d793b4b();
            }
            set
            {
                this.c6225bf0f4b7b2cf556ba4d925e2b1a89(value);
            }
        }

        public string Extension
        {
            get
            {
                return this.c6841b04665eadf0932430e047cc1ee47;
            }
        }

        public string PerceivedType
        {
            get
            {
                return this.c89bad68a2f9ec5e950b5fc65c3d2b6fa();
            }
            set
            {
                this.c8efc793cbf642eef3ebcdf032c5db030(value);
            }
        }

        public string ProgID
        {
            get
            {
                return this.cdab27b76fe5fa1adfec65b69c23df481();
            }
            set
            {
                this.c26bac9c381b9d1d7731bdf7631a63129(value);
            }
        }

        public static LogicNP.ShellObjects.RootKey RootKey
        {
            get
            {
                return c3c8f2bf05792b7cd91c3874f2546562e;
            }
            set
            {
                c3c8f2bf05792b7cd91c3874f2546562e = value;
                if (c3c8f2bf05792b7cd91c3874f2546562e != LogicNP.ShellObjects.RootKey.ClassesRoot)
                {
                    if (c3c8f2bf05792b7cd91c3874f2546562e != LogicNP.ShellObjects.RootKey.CurrentUser)
                    {
                        if (c3c8f2bf05792b7cd91c3874f2546562e != LogicNP.ShellObjects.RootKey.LocalMachine)
                        {
                            return;
                        }
                    Label_0062:
                        switch (3)
                        {
                            case 0:
                                goto Label_0062;
                        }
                        string text4 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x215d);
                        RegistryKey key2 = Registry.LocalMachine.OpenSubKey(text4, true);
                        c9d74ceff2b19d6749de77f39b66900bd = key2;
                        return;
                    }
                Label_0033:
                    switch (3)
                    {
                        case 0:
                            goto Label_0033;
                    }
                    string name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x215d);
                    c9d74ceff2b19d6749de77f39b66900bd = Registry.CurrentUser.OpenSubKey(name, true);
                    return;
                }
            Label_000D:
                switch (7)
                {
                    case 0:
                        goto Label_000D;

                    default:
                        if (1 == 0)
                        {
                        }
                        c9d74ceff2b19d6749de77f39b66900bd = Registry.ClassesRoot;
                        return;
                }
            }
        }
    }
}

