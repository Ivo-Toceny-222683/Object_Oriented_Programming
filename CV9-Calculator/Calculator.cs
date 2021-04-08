namespace CV9_Calculator
{
    internal class Calculator
    {
        public string Memory { get; set; } = "";
        public string Display { get; set; } = "";

        private double number1 = 0;
        private double number2 = 0;
        private double result = 0;

        private enum State
        {
            FirstNum,
            SecondNum,
            Result
        };

        private enum Operation
        {
            Plus,
            Minus,
            Multi,
            Divide
        };


        private State _state = State.FirstNum;
        private Operation _oper;

        public void NumButton(string input)
        {
            switch (input)
            {
                case "0":
                    Display += input;
                    break;
                case "1":
                    Display += input;
                    break;
                case "2":
                    Display += input;
                    break;
                case "3":
                    Display += input;
                    break;
                case "4":
                    Display += input;
                    break;
                case "5":
                    Display += input;
                    break;
                case "6":
                    Display += input;
                    break;
                case "7":
                    Display += input;
                    break;
                case "8":
                    Display += input;
                    break;
                case "9":
                    Display += input;
                    break;
                case ".":
                    Display += input;
                    break;
            }
        }

        public void OperButton(string input)
        {
            
            if (_state == State.SecondNum)
            {
                ResultButton();
            }
            if (_state == State.FirstNum)
            {
                double.TryParse(Display, out number1);
            }

            switch (input)
            {
                case "+":
                    Display += input;
                    _oper = Operation.Plus;
                    break;
                case "-":
                    Display += input;
                    _oper = Operation.Minus;
                    break;
                case "/":
                    Display += input;
                    _oper = Operation.Divide;
                    break;
                case "*":
                    Display += input;
                    _oper = Operation.Multi;
                    break;
            }
            Memory = Display;
            Display = "";
            _state = State.SecondNum;
        }

        public void SystemButton(string input)
        {
            switch (input)
            {
                case "DEL":
                    if (Display.Length > 0)
                    {
                        Display = Display.Substring(0, Display.Length - 1);
                    }
                    break;
                case "C":
                    Display = "";
                    Memory = "";
                    number1 = 0;
                    number2 = 0;
                    _state = State.FirstNum;
                    break;
                case "CE":
                    Display = "";
                    break;
            }
        }

        public void ResultButton()
        {
            double.TryParse(Display, out number2);

            switch (_oper)
            {
                case Operation.Plus:
                    this.result = number1 + number2;
                    Memory = "";
                    Display = result.ToString();
                    _state = State.FirstNum;
                    break;
                case Operation.Minus:
                    this.result = number1 - number2;
                    Memory = "";
                    Display = result.ToString();
                    _state = State.FirstNum;
                    break;
                case Operation.Multi:
                    this.result = number1 * number2;
                    Memory = "";
                    Display = result.ToString();
                    _state = State.FirstNum;
                    break;
                case Operation.Divide:
                    if (number2 == 0)
                    {
                        Memory = "Invalid operation dividing 0";
                        Display = "";
                        number1 = 0;
                        number2 = 0;
                        _state = State.FirstNum;
                        break;
                    }
                    this.result = number1 / number2;
                    Memory = "";
                    Display = result.ToString();
                    _state = State.FirstNum;
                    break;
            }
        }
    }
}