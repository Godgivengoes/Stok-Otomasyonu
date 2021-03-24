using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace StokOtomasyonu
{
    public class AbstractCommunicatorProvider : TypeDescriptionProvider
    {
        public AbstractCommunicatorProvider() : base(TypeDescriptor.GetProvider(typeof(Form)))
        {
        }
        public override Type GetReflectionType(Type objectType, object instance)
        {
            return typeof(Form);
        }
        public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
        {
            objectType = typeof(Form);
            return base.CreateInstance(provider, objectType, argTypes, args);
        }
    }
}