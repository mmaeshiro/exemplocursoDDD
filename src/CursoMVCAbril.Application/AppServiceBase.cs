using CursoMVCAbril.Application.Validation;
using CursoMVCAbril.Domain.ValueObjects;
using CursoMVCAbril.Infra.Data.Interface;
using Microsoft.Practices.ServiceLocation;

namespace CursoMVCAbril.Application
{
    public class AppServiceBase
    {
        private IUnitOfWork _uow;

        public void BeginTransaction()
        {
            _uow = ServiceLocator.Current.GetInstance<IUnitOfWork>();
            _uow.BeginTransaction();
        }

        public void Commit()
        {
            _uow.SaveChanges();
        }

        protected ValidationAppResult DomainToApplicationResult(ValidationResult result)
        {
            var validationAppResult = new ValidationAppResult();

            foreach (var validationError in result.Erros)
            {
                validationAppResult.Erros.Add(new ValidationAppError(validationError.Message));
            }

            validationAppResult.IsValid = result.IsValid;

            return validationAppResult;
        }
    }
}