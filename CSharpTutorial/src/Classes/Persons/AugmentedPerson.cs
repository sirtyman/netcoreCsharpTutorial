namespace Persons
{
    public class AugmentedPerson : Person
    {
        private readonly List<AugmentationBase> _augmentations = new List<AugmentationBase>();

        public AugmentedPerson(): base() => (FirstName, SecondName, Id) = (null, null, null);

        public AugmentedPerson(string firstName, 
            string secondName, string id) : base(firstName, secondName, id) {}

        public List<AugmentationBase> Augmentations {
            get { return _augmentations; }
        }

        new public void Introduce()
        {
            base.Introduce();
            Console.WriteLine("Augmentations:\n");
            foreach (var augmentation in Augmentations)
            {
                Console.WriteLine(augmentation.Description);
            }
        }
    }
}