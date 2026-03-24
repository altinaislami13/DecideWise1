using DecideWise.Data;
using DecideWise.Services;
using DecideWise.UI;

var ui = new ConsoleUI(new DecisionService(new FileRepository()));
ui.Start();