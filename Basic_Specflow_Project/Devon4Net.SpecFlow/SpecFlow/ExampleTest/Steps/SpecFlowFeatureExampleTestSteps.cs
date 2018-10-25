using Devon4Net.SpecFlow.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using TechTalk.SpecFlow;

namespace Devon4Net.SpecFlow.SpecFlow.ExampleTest.Steps
{
    [Binding]
    public class SpecFlowFeatureExampleTestSteps
    {
        private int number1;
        private int number2;
        string numberSerie;
        private int res;
        Table elements;

        [Given(@"I have entered (.*) as first element of calculator")]
        public void GivenIHaveEnteredAsFirstElementOfCalculator(int n1)
        {
            number1 = n1;
        }
        
        [Given(@"I have entered (.*) as second element of calculator")]
        public void GivenIHaveEnteredAsSecondElementOfCalculator(int n2)
        {
            number2 = n2;
        }

        [Given(@"I have recived the following JSON object: '(.*)'")]
        public void GivenIHaveRecivedTheFollowingJSONObject(string p0)
        {
            var numberDto = JsonConvert.DeserializeObject<NumbersDto>(p0);
            number1 = numberDto.Number1;
            number2 = numberDto.Number2;
        }

        [Given(@"I entered the following serie: ""(.*)""")]
        public void GivenIEnteredTheFollowingSerie(string series)
        {
            numberSerie = series;
        }

        [Given(@"I entered numbers")]
        public void GivenIEnteredNumbers(Table table)
        {
            elements = table;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            res = number1 + number2;
        }

        [When(@"I press addSerie")]
        public void WhenIPressAddSerie()
        {
            foreach (string element in numberSerie.Trim().Split(','))
            {
                res += int.Parse(element);
            }
        }

        [When(@"I press addTableElements")]
        public void WhenIPressAddTableElements()
        {
            foreach(var element in elements.Rows)
            {
                res += (int.Parse(element["elements"]));
            }
        }


        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int r)
        {
            Assert.IsTrue(res == r);
        }
        
        [Then(@"the result should not be (.*) on the screen")]
        public void ThenTheResultShouldNotBeOnTheScreen(int r)
        {
            Assert.IsTrue(res != r);
        }
    }
}
