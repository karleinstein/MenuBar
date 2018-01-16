namespace LogicNP.ShellObjects
{
    using A;
    using Microsoft.Win32;
    using System;
    using System.Collections;

    public class ProgIDInfo
    {
        internal const string c23fbf5fb966fe61887dc6840aecef37d = "Specified ProgID does not exist in the registry";
        internal string cff92a148eccb9b024c91f083c207aecb;

        static ProgIDInfo()
        {
            if (FileExtensionInfo.c9d74ceff2b19d6749de77f39b66900bd != null)
            {
                return;
            }
        Label_0007:
            switch (2)
            {
                case 0:
                    goto Label_0007;

                default:
                    if (1 == 0)
                    {
                    }
                    FileExtensionInfo.RootKey = RootKey.CurrentUser;
                    break;
            }
        }

        public ProgIDInfo(string progID)
        {
            this.cff92a148eccb9b024c91f083c207aecb = progID;
        }

        public void AddVerb(ProgIDVerb verb)
        {
            string text3;
            ProgIDVerb[] verbArray2 = this.c1e4f5a5e41724be0f0a393379a56fe21();
            if (verbArray2 == null)
            {
                goto Label_0024;
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
                    if (verbArray2.Length != 0)
                    {
                        goto Label_0031;
                    }
                    break;
            }
        Label_0024:;
            ProgIDVerb[] verbArray = new ProgIDVerb[] { verb };
        Label_0031:
            text3 = verb.Caption;
            int index = this.c85f0ac429026e21fad9a210e3492a0f2(verbArray2, text3);
            if (index < 0)
            {
                verbArray = this.c69b65cc7182d6dd868eb87bc3f0260c7(verbArray2, new ProgIDVerb[] { verb });
                goto Label_007E;
            }
        Label_0047:
            switch (2)
            {
                case 0:
                    goto Label_0047;

                default:
                {
                    string command = verb.Command;
                    verbArray2[index].Command = command;
                    verbArray = verbArray2;
                    break;
                }
            }
        Label_007E:
            this.cea6b3d9bd4615e79a61167791b7334dd(verbArray);
        }

        private void c1407c35c283ebd47faa6387f1344632a(bool cfb2f2abc8e61232ab9b3563c7fc6acf6)
        {
            RegistryKey key = null;
            try
            {
                key = this.c415bfcb88a8d55589d8930c68944a7a9();
                if (key != null)
                {
                    goto Label_0031;
                }
            Label_000C:
                switch (4)
                {
                    case 0:
                        goto Label_000C;

                    default:
                    {
                        if (1 == 0)
                        {
                        }
                        string message = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x222d);
                        throw new InvalidOperationException(message);
                    }
                }
            Label_0031:
                if (cfb2f2abc8e61232ab9b3563c7fc6acf6)
                {
                    key.SetValue(c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x228c), string.Empty);
                }
                else
                {
                    string name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x228c);
                    key.DeleteValue(name, false);
                }
                FileExtensionInfo.cce833f06f74ce72fd6c2fddde19f6f65();
            }
            catch
            {
            }
            finally
            {
                if (key == null)
                {
                    goto Label_007D;
                }
            Label_006D:
                switch (3)
                {
                    case 0:
                        goto Label_006D;

                    default:
                        key.Close();
                        break;
                }
            Label_007D:;
            }
        }

        private ProgIDVerb[] c1e4f5a5e41724be0f0a393379a56fe21()
        {
            Type type2;
            ArrayList list = new ArrayList();
            RegistryKey key = FileExtensionInfo.c9d74ceff2b19d6749de77f39b66900bd.OpenSubKey(this.cff92a148eccb9b024c91f083c207aecb);
            if (key != null)
            {
                string name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x22c0);
                key = key.OpenSubKey(name, false);
                if (key == null)
                {
                    goto Label_0114;
                }
            Label_005B:
                switch (4)
                {
                    case 0:
                        goto Label_005B;
                }
                string[] strArray = key.GetSubKeyNames();
                foreach (string str in strArray)
                {
                    try
                    {
                        object obj3;
                        string text6;
                        RegistryKey key2 = key.OpenSubKey(str);
                        if (key2 != null)
                        {
                            goto Label_009A;
                        }
                    Label_008E:
                        switch (4)
                        {
                            case 0:
                                goto Label_008E;

                            default:
                            {
                                continue;
                            }
                        }
                    Label_009A:
                        text6 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x22cb);
                        RegistryKey key3 = key2.OpenSubKey(text6);
                        key2.Close();
                        if (key3 != null)
                        {
                            goto Label_00C6;
                        }
                    Label_00BA:
                        switch (1)
                        {
                            case 0:
                                goto Label_00BA;

                            default:
                            {
                                continue;
                            }
                        }
                    Label_00C6:
                        obj3 = key3.GetValue(string.Empty, string.Empty);
                        string command = (string) obj3;
                        key3.Close();
                        int num2 = list.Add(new ProgIDVerb(str, command));
                    }
                    catch
                    {
                    }
                }
                key.Close();
                goto Label_0114;
            }
        Label_001C:
            switch (6)
            {
                case 0:
                    goto Label_001C;

                default:
                {
                    if (1 == 0)
                    {
                    }
                    string message = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x222d);
                    throw new InvalidOperationException(message);
                }
            }
        Label_0114:
            type2 = typeof(ProgIDVerb);
            return (ProgIDVerb[]) list.ToArray(type2);
        }

        private RegistryKey c415bfcb88a8d55589d8930c68944a7a9()
        {
            try
            {
                return FileExtensionInfo.c9d74ceff2b19d6749de77f39b66900bd.CreateSubKey(this.cff92a148eccb9b024c91f083c207aecb);
            }
            catch
            {
            }
            return null;
        }

        private ProgIDVerb[] c69b65cc7182d6dd868eb87bc3f0260c7(ProgIDVerb[] c30e03a068e93fee667ea277684420a34, ProgIDVerb[] c08ddb28a170ffc9d24337b2b0bcd38d7)
        {
            ProgIDVerb[] verbArray = new ProgIDVerb[c30e03a068e93fee667ea277684420a34.Length + c08ddb28a170ffc9d24337b2b0bcd38d7.Length];
            int index = 0;
            for (index = 0; index < c30e03a068e93fee667ea277684420a34.Length; index++)
            {
                verbArray[index] = c30e03a068e93fee667ea277684420a34[index];
            }
            for (index = 0; index < c08ddb28a170ffc9d24337b2b0bcd38d7.Length; index++)
            {
                verbArray[c30e03a068e93fee667ea277684420a34.Length + index] = c08ddb28a170ffc9d24337b2b0bcd38d7[index];
            }
            return verbArray;
        }

        private void c728b98f4053ae5d36a3953059175062b(string cfb2f2abc8e61232ab9b3563c7fc6acf6)
        {
            RegistryKey key = null;
            try
            {
                string text3 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x22a7);
                string subkey = this.cff92a148eccb9b024c91f083c207aecb + text3;
                key = FileExtensionInfo.c9d74ceff2b19d6749de77f39b66900bd.CreateSubKey(subkey);
                if (key != null)
                {
                    goto Label_004C;
                }
            Label_0029:
                switch (5)
                {
                    case 0:
                        goto Label_0029;

                    default:
                        if (1 == 0)
                        {
                        }
                        throw new InvalidOperationException(c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x222d));
                }
            Label_004C:
                key.SetValue(string.Empty, cfb2f2abc8e61232ab9b3563c7fc6acf6);
                FileExtensionInfo.cce833f06f74ce72fd6c2fddde19f6f65();
            }
            catch
            {
            }
            finally
            {
                if (key == null)
                {
                    goto Label_0077;
                }
            Label_0067:
                switch (1)
                {
                    case 0:
                        goto Label_0067;

                    default:
                        key.Close();
                        break;
                }
            Label_0077:;
            }
        }

        private void c8512788c98b9545a46e14725f3c690fe(string cfb2f2abc8e61232ab9b3563c7fc6acf6)
        {
            RegistryKey key = null;
            try
            {
                key = this.c415bfcb88a8d55589d8930c68944a7a9();
                if (key != null)
                {
                    goto Label_0033;
                }
            Label_000E:
                switch (2)
                {
                    case 0:
                        goto Label_000E;

                    default:
                    {
                        if (1 == 0)
                        {
                        }
                        string message = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x222d);
                        throw new InvalidOperationException(message);
                    }
                }
            Label_0033:
                key.SetValue(string.Empty, cfb2f2abc8e61232ab9b3563c7fc6acf6);
                FileExtensionInfo.cce833f06f74ce72fd6c2fddde19f6f65();
            }
            catch
            {
            }
            finally
            {
                if (key == null)
                {
                    goto Label_005E;
                }
            Label_004E:
                switch (4)
                {
                    case 0:
                        goto Label_004E;

                    default:
                        key.Close();
                        break;
                }
            Label_005E:;
            }
        }

        private int c85f0ac429026e21fad9a210e3492a0f2(ProgIDVerb[] c6192f61498f55c407944df240be561fe, string c924a7adae948f7734a40ae82ec69a136)
        {
            for (int i = 0; i < c6192f61498f55c407944df240be561fe.Length; i++)
            {
                if (c6192f61498f55c407944df240be561fe[i].Caption == c924a7adae948f7734a40ae82ec69a136)
                {
                    return i;
                }
            }
        Label_0022:
            switch (1)
            {
                case 0:
                    goto Label_0022;
            }
            if (1 == 0)
            {
            }
            return -1;
        }

        private bool c8e9b3fa290d28bd1343eab66ec5a4510()
        {
            RegistryKey key = null;
            try
            {
                object obj4;
                key = this.cf4a119377a9c826e02ac9286c1002ddb();
                if (key != null)
                {
                    goto Label_0033;
                }
            Label_000E:
                switch (6)
                {
                    case 0:
                        goto Label_000E;

                    default:
                    {
                        if (1 == 0)
                        {
                        }
                        string message = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x222d);
                        throw new InvalidOperationException(message);
                    }
                }
            Label_0033:
                obj4 = key.GetValue(c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x228c));
                object obj2 = obj4;
                return (obj2 != null);
            }
            catch
            {
            }
            finally
            {
                if (key == null)
                {
                    goto Label_0068;
                }
            Label_0058:
                switch (6)
                {
                    case 0:
                        goto Label_0058;

                    default:
                        key.Close();
                        break;
                }
            Label_0068:;
            }
            return false;
        }

        private string ca84bdc1e93b749e24c713b2aeec32aff()
        {
            RegistryKey key = null;
            try
            {
                object obj4;
                string text4 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x22a7);
                string name = this.cff92a148eccb9b024c91f083c207aecb + text4;
                key = FileExtensionInfo.c9d74ceff2b19d6749de77f39b66900bd.OpenSubKey(name, false);
                if (key != null)
                {
                    goto Label_0051;
                }
            Label_002C:
                switch (5)
                {
                    case 0:
                        goto Label_002C;

                    default:
                    {
                        if (1 == 0)
                        {
                        }
                        string message = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x222d);
                        throw new InvalidOperationException(message);
                    }
                }
            Label_0051:
                obj4 = key.GetValue(string.Empty);
                object obj2 = obj4;
                if (obj2 != null)
                {
                    string str = obj2 as string;
                    if (str != null)
                    {
                        return str;
                    }
                }
            }
            catch
            {
            }
            finally
            {
                if (key == null)
                {
                    goto Label_008A;
                }
            Label_007A:
                switch (2)
                {
                    case 0:
                        goto Label_007A;

                    default:
                        key.Close();
                        break;
                }
            Label_008A:;
            }
            return string.Empty;
        }

        private string cb4d61a9d60bd61ac2b0dfa8efa47b25c()
        {
            RegistryKey key = null;
            try
            {
                object obj2;
                key = this.cf4a119377a9c826e02ac9286c1002ddb();
                if (key != null)
                {
                    goto Label_0033;
                }
            Label_000E:
                switch (2)
                {
                    case 0:
                        goto Label_000E;

                    default:
                    {
                        if (1 == 0)
                        {
                        }
                        string message = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x222d);
                        throw new InvalidOperationException(message);
                    }
                }
            Label_0033:
                obj2 = key.GetValue(string.Empty);
                if (obj2 == null)
                {
                    goto Label_0075;
                }
                string str = obj2 as string;
                if (str == null)
                {
                    goto Label_0075;
                }
            Label_004C:
                switch (3)
                {
                    case 0:
                        goto Label_004C;
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
                    goto Label_0074;
                }
            Label_0064:
                switch (6)
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

        private void cea6b3d9bd4615e79a61167791b7334dd(ProgIDVerb[] c6192f61498f55c407944df240be561fe)
        {
            RegistryKey key = FileExtensionInfo.c9d74ceff2b19d6749de77f39b66900bd.OpenSubKey(this.cff92a148eccb9b024c91f083c207aecb, true);
            if (key != null)
            {
                try
                {
                    string text10 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x22c0);
                    key.DeleteSubKeyTree(text10);
                }
                catch
                {
                }
                string subkey = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x22c0);
                RegistryKey key2 = key.CreateSubKey(subkey);
                foreach (ProgIDVerb verb in c6192f61498f55c407944df240be561fe)
                {
                    if (verb.Caption == null)
                    {
                        continue;
                    }
                Label_0081:
                    switch (3)
                    {
                        case 0:
                            goto Label_0081;

                        default:
                        {
                            string caption = verb.Caption;
                            if (caption.Length == 0)
                            {
                                continue;
                            }
                            break;
                        }
                    }
                Label_009C:
                    switch (5)
                    {
                        case 0:
                            goto Label_009C;

                        default:
                        {
                            RegistryKey key3 = key2.CreateSubKey(verb.Caption.ToLower());
                            string text15 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x22cb);
                            RegistryKey key4 = key3.CreateSubKey(text15);
                            string command = verb.Command;
                            key4.SetValue(string.Empty, command);
                            key4.Close();
                            key3.Close();
                            break;
                        }
                    }
                }
            Label_0104:
                switch (7)
                {
                    case 0:
                        goto Label_0104;
                }
                FileExtensionInfo.cce833f06f74ce72fd6c2fddde19f6f65();
                return;
            }
        Label_0017:
            switch (3)
            {
                case 0:
                    goto Label_0017;
            }
            if (1 == 0)
            {
            }
            string message = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x222d);
            throw new InvalidOperationException(message);
        }

        private RegistryKey cf4a119377a9c826e02ac9286c1002ddb()
        {
            try
            {
                return FileExtensionInfo.c9d74ceff2b19d6749de77f39b66900bd.OpenSubKey(this.cff92a148eccb9b024c91f083c207aecb, false);
            }
            catch
            {
            }
            return null;
        }

        public bool Delete()
        {
            try
            {
                FileExtensionInfo.c9d74ceff2b19d6749de77f39b66900bd.DeleteSubKeyTree(this.cff92a148eccb9b024c91f083c207aecb);
                return true;
            }
            catch
            {
            }
            return false;
        }

        public void RemoveVerb(string caption)
        {
            ProgIDVerb[] verbArray = this.c1e4f5a5e41724be0f0a393379a56fe21();
            if ((verbArray != null) && (verbArray.Length != 0))
            {
                int index = this.c85f0ac429026e21fad9a210e3492a0f2(verbArray, caption);
                if (index >= 0)
                {
                    verbArray[index].Caption = string.Empty;
                    this.cea6b3d9bd4615e79a61167791b7334dd(verbArray);
                }
            }
        }

        public bool AlwaysShowExtension
        {
            get
            {
                return this.c8e9b3fa290d28bd1343eab66ec5a4510();
            }
            set
            {
                this.c1407c35c283ebd47faa6387f1344632a(value);
            }
        }

        public string DefaultIcon
        {
            get
            {
                return this.ca84bdc1e93b749e24c713b2aeec32aff();
            }
            set
            {
                this.c728b98f4053ae5d36a3953059175062b(value);
            }
        }

        public string Description
        {
            get
            {
                return this.cb4d61a9d60bd61ac2b0dfa8efa47b25c();
            }
            set
            {
                this.c8512788c98b9545a46e14725f3c690fe(value);
            }
        }

        public string ProgID
        {
            get
            {
                return this.cff92a148eccb9b024c91f083c207aecb;
            }
        }

        public ProgIDVerb[] Verbs
        {
            get
            {
                return this.c1e4f5a5e41724be0f0a393379a56fe21();
            }
            set
            {
                this.cea6b3d9bd4615e79a61167791b7334dd(value);
            }
        }
    }
}

