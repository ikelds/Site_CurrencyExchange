var dataCurrency; // Переменная для хранения текущей выбранной валюты.
var dataOperation; // Переменная для хранения текущей выбранной операции продажа или покупка.
var dataCours; // Курс, который выбрал пользователь с помощью переключателя.
var dataDate; // Дата расчетов.

// Заполним сумму обмена по умолчанию
document.getElementById('myInput').value = 5000;

function updateParams() {

    // Сохраним в переменную сумму обмена, которую ввел пользователь.
    var sum = document.getElementById("myInput").value;

    // Сохраним текущее состояние всех 4х переключателей.
    var course = document.getElementsByName("course");

    for (var i = 0; i < course.length; i++) {

        // Определим выбранный переключатель и считаем валюту и операцию с него.
        if (course[i].checked) {
            dataCurrency = course[i].getAttribute("data-currency");
            dataOperation = course[i].getAttribute("data-operation");
            dataCours = course[i].getAttribute("data-course");
        }
    }

    dataDate = new Date();

    $('.js-amount').html(sum);
    $('.js-operation').html(dataOperation === 'buy' ? 'продаю' : 'покупаю');
    $('.js-currency').html(dataCurrency === 'usd' ? '$' : '€');
    $('.js-selected_cours').html(dataCours);
    $('.js-сurrDate').html(dataDate.toLocaleDateString());
    $('.js-totalSumm').html((sum * dataCours).toFixed(2));
    $('.js-button').html(dataOperation === 'buy' ? 'Продать валюту' : 'Купить валюту');
}

// Установим интервал перезапуска функции.
setInterval(updateParams, 500);