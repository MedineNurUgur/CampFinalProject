using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğulama sınıfı değil");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            //burada validator ı çalışma anında new ledi
            var validator = (IValidator)Activator.CreateInstance(_validatorType);//reflection : çalışma anında birşey yaptırmaya yarar.
            var entityType = _validatorType.BaseType.GetGenericArguments()[0]; // o validatr için gerekili olan nesneyi bul
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);//invocation çalıştırılan metod. 
            //Metod un istediği parametreleri gez hangisi entity onu al validate et
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
