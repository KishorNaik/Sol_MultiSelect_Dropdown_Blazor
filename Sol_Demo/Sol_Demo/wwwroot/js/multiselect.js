function applySelect2JavascriptPlugin(element) {

    // $("#" + element).select2();
    $('.js-example-basic-multiple').select2();

    $('.js-example-basic-multiple').on('select2:select', function (e) {
        var data = e.params.data;

        let id = data.id;
        console.log(id);

        DotNet.invokeMethodAsync('Sol_Demo', 'OnDropDownChangedEventJS', id);
        
    });

    
}