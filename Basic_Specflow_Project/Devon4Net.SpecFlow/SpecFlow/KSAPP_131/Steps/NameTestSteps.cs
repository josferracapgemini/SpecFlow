using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace Devon4Net.SpecFlow.SpecFlow.KSAPP_131.Steps
{
    [Binding]
    public class NameTestSteps
    {
        private int number1;
        private int number2;
        private int res;

        [Given(@"I have entered (.*) into the calculator as first number")]
        public void GivenIHaveEnteredIntoTheCalculatorAsFirstNumber(int n1)
        {
            number1 = n1;
        }

        [Given(@"I have entered (.*) into the calculator as second number")]
        public void GivenIHaveEnteredIntoTheCalculatorAsSecondNumber(int n2)
        {
            number2 = n2;
        }
        
        [When(@"I press adds")]
        public void WhenIPressAdds()
        {
            res = number1 + number2;
        }
        
        [Then(@"the result should be (.*) on the screens")]
        public void ThenTheResultShouldBeOnTheScreens(int r)
        {
            Assert.IsTrue(res == r);
        }
    }
}
