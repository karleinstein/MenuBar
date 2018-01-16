namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.Collections;
    using System.Reflection;

    public class WizardPageCollection : IList, ICollection, IEnumerable
    {
        private Wizard c1ddc887212aafbd9ba7cb9b75b60e84e;
        private ArrayList cb506ab7cdadec87b67d7e29410151747;

        internal WizardPageCollection(Wizard c1ddc887212aafbd9ba7cb9b75b60e84e)
        {
            this.c1ddc887212aafbd9ba7cb9b75b60e84e = c1ddc887212aafbd9ba7cb9b75b60e84e;
            this.cb506ab7cdadec87b67d7e29410151747 = new ArrayList(5);
        }

        public int Add(WizardPage page)
        {
            int index = this.cb506ab7cdadec87b67d7e29410151747.Count;
            this.Insert(index, page);
            return index;
        }

        public void AddRange(WizardPage[] pageArray)
        {
            for (int i = 0; i < pageArray.Length; i++)
            {
                int num2 = this.Add(pageArray[i]);
            }
        Label_001A:
            switch (5)
            {
                case 0:
                    goto Label_001A;
            }
            if (1 == 0)
            {
            }
        }

        private int c4923e31f428abc830296a78c6a36865b(object cfb2f2abc8e61232ab9b3563c7fc6acf6)
        {
            WizardPage page = cfb2f2abc8e61232ab9b3563c7fc6acf6 as WizardPage;
            if (page != null)
            {
                return this.Add(page);
            }
        Label_000A:
            switch (5)
            {
                case 0:
                    goto Label_000A;
            }
            if (1 == 0)
            {
            }
            string message = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xe0);
            throw new ArgumentException(message);
        }

        private int c5e43e45bee532cdd27726bb75e4459d1(object cfb2f2abc8e61232ab9b3563c7fc6acf6)
        {
            WizardPage page = cfb2f2abc8e61232ab9b3563c7fc6acf6 as WizardPage;
            if (page != null)
            {
                return this.IndexOf(page);
            }
        Label_000A:
            switch (5)
            {
                case 0:
                    goto Label_000A;
            }
            if (1 == 0)
            {
            }
            string message = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xe0);
            throw new ArgumentException(message);
        }

        private bool c783bad4206caef4ecefda2449461ebe4(object cfb2f2abc8e61232ab9b3563c7fc6acf6)
        {
            WizardPage page = cfb2f2abc8e61232ab9b3563c7fc6acf6 as WizardPage;
            if (page != null)
            {
                return this.Contains(page);
            }
        Label_000A:
            switch (5)
            {
                case 0:
                    goto Label_000A;
            }
            if (1 == 0)
            {
            }
            return false;
        }

        private void c8322884c79f79a1c3f618fa8911cba9b(object cfb2f2abc8e61232ab9b3563c7fc6acf6)
        {
            WizardPage page = cfb2f2abc8e61232ab9b3563c7fc6acf6 as WizardPage;
            if (page == null)
            {
                return;
            }
        Label_000A:
            switch (7)
            {
                case 0:
                    goto Label_000A;

                default:
                    if (1 == 0)
                    {
                    }
                    this.Remove(page);
                    break;
            }
        }

        private void ceeda9d2f8bbda1c5f7502060c28806eb(Array ce37dd76708cce98e9137f41c558b6d66, int cf0836916dccce7c844b0870aa147ff01)
        {
            this.cb506ab7cdadec87b67d7e29410151747.CopyTo(ce37dd76708cce98e9137f41c558b6d66, cf0836916dccce7c844b0870aa147ff01);
        }

        private void cf6b4e86f956cb4251eee177bc81b012a(int cf0836916dccce7c844b0870aa147ff01, object cfb2f2abc8e61232ab9b3563c7fc6acf6)
        {
            WizardPage page = cfb2f2abc8e61232ab9b3563c7fc6acf6 as WizardPage;
            if (page != null)
            {
                this.Insert(cf0836916dccce7c844b0870aa147ff01, page);
                return;
            }
        Label_000A:
            switch (3)
            {
                case 0:
                    goto Label_000A;
            }
            if (1 == 0)
            {
            }
            throw new ArgumentException(c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xe0));
        }

        public void Clear()
        {
            int count = this.cb506ab7cdadec87b67d7e29410151747.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                this.RemoveAt(i);
            }
        Label_0021:
            switch (3)
            {
                case 0:
                    goto Label_0021;
            }
            if (1 == 0)
            {
            }
        }

        public bool Contains(WizardPage page)
        {
            return this.cb506ab7cdadec87b67d7e29410151747.Contains(page);
        }

        public IEnumerator GetEnumerator()
        {
            return this.cb506ab7cdadec87b67d7e29410151747.GetEnumerator();
        }

        public int IndexOf(WizardPage page)
        {
            return this.cb506ab7cdadec87b67d7e29410151747.IndexOf(page);
        }

        public void Insert(int index, WizardPage page)
        {
            if (page == null)
            {
                string paramName = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x548);
                throw new ArgumentNullException(paramName);
            }
            if (index < 0)
            {
                goto Label_003C;
            }
            int count = this.cb506ab7cdadec87b67d7e29410151747.Count;
            if (index <= count)
            {
                this.cb506ab7cdadec87b67d7e29410151747.Insert(index, page);
                this.c1ddc887212aafbd9ba7cb9b75b60e84e.c99c67dddbf24e7a3ba6eeb0002064e54(page);
                return;
            }
        Label_0029:
            switch (2)
            {
                case 0:
                    goto Label_0029;

                default:
                    if (1 == 0)
                    {
                    }
                    break;
            }
        Label_003C:
            throw new IndexOutOfRangeException();
        }

        public void Remove(WizardPage page)
        {
            if (page != null)
            {
                if (page.c1ddc887212aafbd9ba7cb9b75b60e84e == this.c1ddc887212aafbd9ba7cb9b75b60e84e)
                {
                    int num = this.IndexOf(page);
                    this.RemoveAt(num);
                    return;
                }
            Label_0036:
                switch (3)
                {
                    case 0:
                        goto Label_0036;
                }
                return;
            }
        Label_0003:
            switch (6)
            {
                case 0:
                    goto Label_0003;
            }
            if (1 == 0)
            {
            }
            string paramName = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x548);
            throw new ArgumentNullException(paramName);
        }

        public void RemoveAt(int index)
        {
            if (index < 0)
            {
                goto Label_0031;
            }
        Label_0004:
            switch (2)
            {
                case 0:
                    goto Label_0004;

                default:
                {
                    if (1 == 0)
                    {
                    }
                    int count = this.cb506ab7cdadec87b67d7e29410151747.Count;
                    if (index < count)
                    {
                        object obj2 = this.cb506ab7cdadec87b67d7e29410151747[index];
                        WizardPage page = obj2 as WizardPage;
                        this.c1ddc887212aafbd9ba7cb9b75b60e84e.c518ce5db31843ed01190bb3742db3b2f(page);
                        this.cb506ab7cdadec87b67d7e29410151747.RemoveAt(index);
                        this.c1ddc887212aafbd9ba7cb9b75b60e84e.ca2522d5e11ddbc8e707d4e3d76ae5ce5(page);
                        return;
                    }
                    break;
                }
            }
        Label_0027:
            switch (4)
            {
                case 0:
                    goto Label_0027;
            }
        Label_0031:
            throw new IndexOutOfRangeException();
        }

        private bool c2997339e954435ceaa401b19d6a79276
        {
            get
            {
                return false;
            }
        }

        private bool c86e3d457d9929f79baae74f44e6f12ee
        {
            get
            {
                return false;
            }
        }

        private object cc6abde3205806adcd67572fa3f87997a
        {
            get
            {
                return this;
            }
        }

        private object this[int cf0836916dccce7c844b0870aa147ff01]
        {
            get
            {
                return this[cf0836916dccce7c844b0870aa147ff01];
            }
            set
            {
                if (value is WizardPage)
                {
                    this[cf0836916dccce7c844b0870aa147ff01] = value as WizardPage;
                    return;
                }
            Label_000A:
                switch (5)
                {
                    case 0:
                        goto Label_000A;
                }
                if (1 == 0)
                {
                }
                string message = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xe0);
                throw new ArgumentException(message);
            }
        }

        public int Count
        {
            get
            {
                return this.cb506ab7cdadec87b67d7e29410151747.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public WizardPage this[int index]
        {
            get
            {
                return (this.cb506ab7cdadec87b67d7e29410151747[index] as WizardPage);
            }
            set
            {
                if (value != null)
                {
                    if (index < 0)
                    {
                        goto Label_004E;
                    }
                Label_002C:
                    switch (6)
                    {
                        case 0:
                            goto Label_002C;

                        default:
                            if (index < this.cb506ab7cdadec87b67d7e29410151747.Count)
                            {
                                object obj2 = this.cb506ab7cdadec87b67d7e29410151747[index];
                                WizardPage page = obj2 as WizardPage;
                                if (page != value)
                                {
                                    this.c1ddc887212aafbd9ba7cb9b75b60e84e.c518ce5db31843ed01190bb3742db3b2f(page);
                                    this.cb506ab7cdadec87b67d7e29410151747[index] = value;
                                    this.c1ddc887212aafbd9ba7cb9b75b60e84e.c99c67dddbf24e7a3ba6eeb0002064e54(value);
                                    return;
                                }
                            Label_006C:
                                switch (6)
                                {
                                    case 0:
                                        goto Label_006C;
                                }
                                return;
                            }
                            break;
                    }
                Label_0044:
                    switch (3)
                    {
                        case 0:
                            goto Label_0044;
                    }
                    goto Label_004E;
                }
            Label_0003:
                switch (2)
                {
                    case 0:
                        goto Label_0003;

                    default:
                    {
                        if (1 == 0)
                        {
                        }
                        string paramName = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xe0);
                        throw new ArgumentNullException(paramName);
                    }
                }
            Label_004E:
                throw new IndexOutOfRangeException();
            }
        }

        [__DynamicallyInvokable]
        private bool System.Collections.ICollection.IsSynchronized
        {
            get
            {
                return false;
            }
        }

        [__DynamicallyInvokable]
        private object System.Collections.ICollection.SyncRoot
        {
            get
            {
                return this;
            }
        }

        [__DynamicallyInvokable]
        private bool System.Collections.IList.IsFixedSize
        {
            get
            {
                return false;
            }
        }

        [__DynamicallyInvokable]
        private object this[int index]
        {
            get
            {
                return this[cf0836916dccce7c844b0870aa147ff01];
            }
            set
            {
                if (value is WizardPage)
                {
                    this[cf0836916dccce7c844b0870aa147ff01] = value as WizardPage;
                    return;
                }
            Label_000A:
                switch (5)
                {
                    case 0:
                        goto Label_000A;
                }
                if (1 == 0)
                {
                }
                string message = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xe0);
                throw new ArgumentException(message);
            }
        }
    }
}

