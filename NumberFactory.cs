namespace PaoloCattaneo.TooMuchFluent;

public class NumberFactory 
{
    private record IndexValue(int Index, int Value);

    private List<IndexValue> values;

    public NumberFactory() {
        values = new List<IndexValue>();
    }

    public NumberFactory Units(int value) {
        values.Add(new IndexValue(1, value));
        return this;
    }

    public NumberFactory Decimals(int value) {
        values.Add(new IndexValue(10, value));
        return this;
    }

    public NumberFactory Hundreds(int value) {
        values.Add(new IndexValue(100, value));
        return this;
    }

    public NumberFactory Thousands(int value) {
        values.Add(new IndexValue(1000, value));
        return this;
    }

    public int Build() {
        var result = 0;
        foreach(var value in values) {
            result += (value.Index * value.Value);
        }
        return result;
    }
}