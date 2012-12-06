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

    public class when_comparing_two_items_that_are_the_same : concern
    {
        Establish c = () =>
        {
            comparer = depends.on<IComparer<int>>();
            comparer.setup(x => x.Compare(1, 1)).Return(0);
        };

        Because b = () => result = sut.Compare(1, 1);

        It should_return_zero = () => result.ShouldEqual(0);

        static int result;
        static IComparer<int> comparer;
    }

    public class when_comparing_two_items_where_the_first_is_lower : concern
    {
        Establish c = () =>
        {
            comparer = depends.on<IComparer<int>>();
            comparer.setup(x => x.Compare(1, 2)).Return(-1);
        };

        Because b = () => result = sut.Compare(1, 2);

        It should_return_positive_one = () => result.ShouldEqual(1);

        static int result;
        static IComparer<int> comparer;
    }

    public class when_comparing_two_items_where_the_first_is_higer : concern
    {
        Establish c = () =>
        {
            comparer = depends.on<IComparer<int>>();
            comparer.setup(x => x.Compare(2, 1)).Return(1);
        };

        Because b = () => result = sut.Compare(2, 1);

        It should_return_negative_one = () => result.ShouldEqual(-1);

        static int result;
        static IComparer<int> comparer;
    }
  }
}
