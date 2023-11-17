namespace CursoDio.API.Models
{
    public class ValidateFieldsViewModelOutput
    {
        public IEnumerable<string> errors { get; private set; }

        public ValidateFieldsViewModelOutput(IEnumerable<string> errors)
        {
            this.errors = errors;
        }

    }
}