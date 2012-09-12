using Machine.Specifications;

namespace app.specs
{
  [Subject(typeof(Calculator))]
  public class when_adding_2_positive_numbers
  {
    It should_return_the_sum = () =>
      Calculator.add(2, 3).ShouldEqual(5);
  }
}