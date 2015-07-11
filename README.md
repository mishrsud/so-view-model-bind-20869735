# Binding Alias Name to ViewModel Property
Stackoverflow question 20869735 [how-to-bind-view-model-property-with-different-name](http://stackoverflow.com/questions/20869735/how-to-bind-view-model-property-with-different-name)

When you want to use it:

    [ModelBinder(typeof(AliasModelBinder))]
    public class FilterViewModel
    {
        [BindAlias("someText")]
        public string FilterParameter { get; set; }
    }

In html:

    @* at least you dont write "someText" here again *@
    @Html.Editor(Html.AliasNameFor(model => model.FilterParameter))
    @Html.ValidationMessage(Html.AliasNameFor(model => model.FilterParameter))
    
Generated html output contains input element by using BindAlias and sets name attribute to "someText".
