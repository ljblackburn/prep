using System.Collections.Generic;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using Machine.Specifications;
using prep.utility.sorting;

namespace prep.specs
{
  [Subject(typeof(ReverseComparer<>))]
  public class ReverseComparerSpecs
  {
    public abstract class concern : Observes<IComparer<int>, ReverseComparer<int>> 
    {
    }

    public class when_comparing_two_items : concern
    {
        Establish c = () =>
        {
            comparer = depends.on<IComparer<int>>();
            comparer.setup(x => x.Compare(2, 1)).Return(1);
        };

        Because b = () => result = sut.Compare(2, 1);

        It should_return_the_negated_value = () => result.ShouldEqual(-1);

        static int result;
        static IComparer<int> comparer;
    }
  }
}
