
$(document).ready(function () {

    $('.nameFilter').change(function () {
        var nameValue = $('.nameFilter').val();
        var name;

        if (nameValue != '') {
            $('.home-record').each(function () {
                name = $(this).find('.nameValue').text();

                if (nameValue == name) {
                    $(this).removeClass('hidden');
                } else {
                    $(this).addClass('hidden');
                }
            });

        } else {
            $('.home-record').each(function () {
                $(this).removeClass('hidden');
            });
        }
    });


    $('.priceFilter').change(function () {
        var prValue = $('.priceFilter').val();

        if (prValue != '') {
            var min = parseFloat(prValue.split('-')[0]);
            var max = parseFloat(prValue.split('-')[1]);
            var price;

            $('.home-record').each(function () {
                price = $(this).find('.priceValue').text();
                myPrice = parseFloat(price.substring(1, price.length));

                if (myPrice >= min && myPrice <= max) {
                    $(this).removeClass('hidden');
                } else {
                    $(this).addClass('hidden');
                }
            });

        } else {
            $('.home-record').each(function () {
                $(this).removeClass('hidden');
            });
        }
    });


    $('.bedFilter').change(function () {
        var bedValue = $('.bedFilter').val();
        var bed;


        if (bedValue != '') {
            $('.home-record').each(function () {

                bed = $(this).find('.bedValue').text();

                if (bedValue === bed) {
                    $(this).removeClass('hidden');
                } else {
                    $(this).addClass('hidden');
                }
            });

        } else {
            $('.home-record').each(function () {
                $(this).removeClass('hidden');
            });
        }
    });


    $('.zipFilter').change(function () {
        var zipValue = $('.zipFilter').val();
        var zip;

        if (zipValue != '') {
            $('.home-record').each(function () {
                zip = $(this).find('.zipValue').text();

                if (zipValue == zip) {
                    $(this).removeClass('hidden');
                } else {
                    $(this).addClass('hidden');
                }
            });

        } else {
            $('.home-record').each(function () {
                $(this).removeClass('hidden');
            });
        }
    });

});