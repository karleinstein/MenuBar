namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.Collections;
    using System.Reflection;

    public class TriggerList : IList, ICollection, IEnumerable, IDisposable
    {
        private ce00c0c0cf6fda959b5e473451484f374 c314ce52ce2ae293d8113116cadfd940f;
        private ArrayList c73e3ab578e509cae5a056499286a955e;

        internal TriggerList(ce00c0c0cf6fda959b5e473451484f374 c314ce52ce2ae293d8113116cadfd940f)
        {
            this.c314ce52ce2ae293d8113116cadfd940f = c314ce52ce2ae293d8113116cadfd940f;
            ushort num = 0;
            c314ce52ce2ae293d8113116cadfd940f.cb98ceb58565a5bb1e1a3b82aa6c54f21(out num);
            this.c73e3ab578e509cae5a056499286a955e = new ArrayList(num + 5);
            for (int i = 0; i < num; i++)
            {
                c60ef56b1c0a7e1d5ec52b0d39d9d16b6 cefbcaedecbdddb;
                c314ce52ce2ae293d8113116cadfd940f.cc183ac3fb0fb187e8886fd5ac15c580d((ushort) i, out cefbcaedecbdddb);
                Trigger trigger2 = Trigger.c7bfc2b235ca5eb1d25d87201e49cdf93(cefbcaedecbdddb);
                int num3 = this.c73e3ab578e509cae5a056499286a955e.Add(trigger2);
            }
        Label_0051:
            switch (3)
            {
                case 0:
                    goto Label_0051;
            }
            if (1 == 0)
            {
            }
        }

        public int Add(Trigger trigger)
        {
            if (!trigger.c9518ed52a114e714e16c06ffdde12706)
            {
                c60ef56b1c0a7e1d5ec52b0d39d9d16b6 cefbcaedecbdddb;
                ushort num;
                this.c314ce52ce2ae293d8113116cadfd940f.c7bfc2b235ca5eb1d25d87201e49cdf93(out num, out cefbcaedecbdddb);
                trigger.c2ffcc2be8cbb4559d8fa35d2c9369a60(cefbcaedecbdddb);
                int num3 = this.c73e3ab578e509cae5a056499286a955e.Add(trigger);
                if (num3 != num)
                {
                    throw new ApplicationException();
                }
                return num;
            }
        Label_000A:
            switch (7)
            {
                case 0:
                    goto Label_000A;
            }
            if (1 == 0)
            {
            }
            throw new ArgumentException();
        }

        private int c4923e31f428abc830296a78c6a36865b(object cfb2f2abc8e61232ab9b3563c7fc6acf6)
        {
            return this.Add(cfb2f2abc8e61232ab9b3563c7fc6acf6 as Trigger);
        }

        private int c5e43e45bee532cdd27726bb75e4459d1(object cfb2f2abc8e61232ab9b3563c7fc6acf6)
        {
            return this.IndexOf(cfb2f2abc8e61232ab9b3563c7fc6acf6 as Trigger);
        }

        private bool c783bad4206caef4ecefda2449461ebe4(object cfb2f2abc8e61232ab9b3563c7fc6acf6)
        {
            return this.Contains(cfb2f2abc8e61232ab9b3563c7fc6acf6 as Trigger);
        }

        private void c8322884c79f79a1c3f618fa8911cba9b(object cfb2f2abc8e61232ab9b3563c7fc6acf6)
        {
            this.Remove(cfb2f2abc8e61232ab9b3563c7fc6acf6 as Trigger);
        }

        private void cf6b4e86f956cb4251eee177bc81b012a(int cf0836916dccce7c844b0870aa147ff01, object cfb2f2abc8e61232ab9b3563c7fc6acf6)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            int count = this.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                this.RemoveAt(i);
            }
        Label_001C:
            switch (5)
            {
                case 0:
                    goto Label_001C;
            }
            if (1 == 0)
            {
            }
        }

        public bool Contains(Trigger trigger)
        {
            return (this.IndexOf(trigger) != -1);
        }

        public void CopyTo(Array array, int index)
        {
            if (this.c73e3ab578e509cae5a056499286a955e.Count <= (array.Length - index))
            {
                int num4;
                int num = 0;
            Label_005B:
                num4 = this.c73e3ab578e509cae5a056499286a955e.Count;
                if (num < num4)
                {
                    object obj3 = this.c73e3ab578e509cae5a056499286a955e[num];
                    object obj4 = ((Trigger) obj3).Clone();
                    array.SetValue(obj4, (int) (index + num));
                    num++;
                    goto Label_005B;
                }
                goto Label_006B;
            }
        Label_0017:
            switch (1)
            {
                case 0:
                    goto Label_0017;

                default:
                    if (1 == 0)
                    {
                    }
                    throw new ArgumentException();
            }
        Label_006B:
            switch (1)
            {
                case 0:
                    goto Label_006B;
            }
        }

        public void Dispose()
        {
            IEnumerator enumerator = this.c73e3ab578e509cae5a056499286a955e.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    object obj2 = enumerator.Current;
                    ((Trigger) obj2).cfab69a397aedbc93489a509309b87405();
                }
            Label_002C:
                switch (3)
                {
                    case 0:
                        goto Label_002C;
                }
                if (1 == 0)
                {
                }
            }
            finally
            {
                IDisposable disposable = enumerator as IDisposable;
                if (disposable == null)
                {
                    goto Label_005B;
                }
            Label_004B:
                switch (3)
                {
                    case 0:
                        goto Label_004B;

                    default:
                        disposable.Dispose();
                        break;
                }
            Label_005B:;
            }
            this.c73e3ab578e509cae5a056499286a955e = null;
            this.c314ce52ce2ae293d8113116cadfd940f = null;
        }

        public IEnumerator GetEnumerator()
        {
            return this.c73e3ab578e509cae5a056499286a955e.GetEnumerator();
        }

        public int IndexOf(Trigger trigger)
        {
            for (int i = 0; i < this.Count; i++)
            {
                Trigger trigger2 = this[i];
                if (!trigger2.Equals(trigger))
                {
                    continue;
                }
            Label_0017:
                switch (3)
                {
                    case 0:
                        goto Label_0017;

                    default:
                        if (1 == 0)
                        {
                        }
                        return i;
                }
            }
        Label_0039:
            switch (5)
            {
                case 0:
                    goto Label_0039;
            }
            return -1;
        }

        public void Remove(Trigger trigger)
        {
            int num = this.IndexOf(trigger);
            if (num == -1)
            {
                return;
            }
        Label_000E:
            switch (3)
            {
                case 0:
                    goto Label_000E;

                default:
                    if (1 == 0)
                    {
                    }
                    this.RemoveAt(num);
                    break;
            }
        }

        public void RemoveAt(int index)
        {
            int count = this.Count;
            if (index >= count)
            {
                throw new ArgumentOutOfRangeException();
            }
            object obj1 = this.c73e3ab578e509cae5a056499286a955e[index];
            ((Trigger) obj1).cfab69a397aedbc93489a509309b87405();
            this.c73e3ab578e509cae5a056499286a955e.RemoveAt(index);
            this.c314ce52ce2ae293d8113116cadfd940f.c1fb8efdb03199c4bef4df97f1fba263e((ushort) index);
        }

        private object this[int cf0836916dccce7c844b0870aa147ff01]
        {
            get
            {
                return this[cf0836916dccce7c844b0870aa147ff01];
            }
            set
            {
                this[cf0836916dccce7c844b0870aa147ff01] = value as Trigger;
            }
        }

        public int Count
        {
            get
            {
                return this.c73e3ab578e509cae5a056499286a955e.Count;
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return false;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }

        public Trigger this[int index]
        {
            get
            {
                int count = this.Count;
                if (index < count)
                {
                    object obj2 = this.c73e3ab578e509cae5a056499286a955e[index];
                    return (Trigger) obj2;
                }
            Label_000B:
                switch (2)
                {
                    case 0:
                        goto Label_000B;
                }
                if (1 == 0)
                {
                }
                throw new ArgumentOutOfRangeException();
            }
            set
            {
                int count = this.Count;
                if (index < count)
                {
                    object obj2 = this.c73e3ab578e509cae5a056499286a955e[index];
                    Trigger trigger = (Trigger) obj2;
                    value.c2ffcc2be8cbb4559d8fa35d2c9369a60(trigger);
                    this.c73e3ab578e509cae5a056499286a955e[index] = value;
                    return;
                }
            Label_000B:
                switch (7)
                {
                    case 0:
                        goto Label_000B;
                }
                if (1 == 0)
                {
                }
                throw new ArgumentOutOfRangeException();
            }
        }

        public object SyncRoot
        {
            get
            {
                return null;
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
                this[cf0836916dccce7c844b0870aa147ff01] = value as Trigger;
            }
        }
    }
}

