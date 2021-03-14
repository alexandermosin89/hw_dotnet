using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class Motorcycle
    {
        const ushort fueltank = 40;
        private ushort fueltankPrivate = 41;
        protected private ushort fueltankProtectedPrivate = 42;
        int odometr = 32560;
        protected int odometrProtected = 32561;
        internal int odometrInternal = 32562;
        protected internal int odometrProtectedInternal = 32563;
        const string vinnumber = "3260WW543LKS12Z";
        void StartEngine()
        { }
        private void StartEnginePrivate()
        { }
        protected private void StopEngineProtPriv()
        { }
        protected void StopEngineProtected()
        { }
        internal void StopEngineInternal()
        { }
        protected internal void StopEngineInternalProtected()
        { }
        public void StopEnginePublic()
        { }
    }
        class SportBike : Motorcycle
        {
            protected int MaxSpeedProtected = 500;
            protected internal int MaxSpeedProtectedInternal = 501;
            private protected int MaxSpeedPrivateProtected = 502;
        }
    
}
