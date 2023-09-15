namespace CounterEvent
{
    public class Counter
    {
        // Déclaration d'un délégué pour l'événement
        public delegate void ChangedValueEventHandler (int newValue);

		private int _value; // default(int) : 0

        // Événement déclenché lors que la valeur change
        public event ChangedValueEventHandler ChangedValue;

        public void Increment()
        {
            _value++;

            // Vérifier si quelqu'un est abonné à l'événement
            //if (ChangedValue != null) 
            //{
            //    ChangedValue(_value);
            //}

            ChangedValue?.Invoke(_value);

        }

	}
}
