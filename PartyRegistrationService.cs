namespace Mentoring.Solid.SingleResponsibility
{
    public class PartyRegistrationService
    {
        private readonly Repository _repository;

        public PartyRegistrationService(Repository repository)
        {
            _repository = repository;
        }
        public string Register(string emailAddress, string name)
        {
            _repository.StoreRegisteredUser(emailAddress, name);

            return $"User: {name} has successfully be added to the party.";
        }
    }
}