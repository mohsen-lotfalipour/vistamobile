function showResult(str) {
    if (str.length == 0) {
        document.getElementById("livesearch").innerHTML = "";
        document.getElementById("livesearch").style.border = "0px";
        return;
    }
    if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
        xmlhttp = new XMLHttpRequest();
    }
    else {// code for IE6, IE5
        xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
    }
    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            document.getElementById("livesearch").innerHTML = xmlhttp.responseText;
            document.getElementById("livesearch").style.border = "1px solid #A5ACB2";
        }
    }
    xmlhttp.open("GET", "searchproduct.aspx?q=" + str, true);
    xmlhttp.send();
}
function number2() {
    $(".numbered > .clickable").click(function (ev) {
        ev.preventDefault();
        var number = parseInt($(this).siblings('input[type="text"]').val(), 10);
        var totalprice = parseInt($(this).parent().parent().next().next().text(), 10);
        var unitprice = totalprice / number;
        var total = parseInt($("#total_price_review").text(), 10);
        if (isNaN(number)) {
            number = 1;
        }
        if ($(this).hasClass("add-one")) {
            $(this).siblings('input[type="text"]').val(number + 1);
            $(this).parent().parent().next().next().text(totalprice + unitprice + "  ریال  ");
            $("#total_price_review").text(total + unitprice + "  ریال  ");
        } else {
            number = number < 2 ? 2 : number;
            $(this).siblings('input[type="text"]').val(number - 1);
            unitprice = unitprice == totalprice ? 0 : unitprice;
            $(this).parent().parent().next().next().text(totalprice - unitprice + "  ریال  ");
            $("#total_price_review").text(total - unitprice + "  ریال  ");
        }
    });

}
function call_modal(modalname) {
    $("#" + modalname.toString()).modal('show');
}

function addtocart(id) {
    var cart = $('.icon-shopping-cart');

    var imgtodrag = $("#" + id.toString());

    if (imgtodrag) {
        $(".img-overlay").hide();
        var imgclone = imgtodrag.clone()
                .offset({
                    top: imgtodrag.offset().top,
                    left: imgtodrag.offset().left
                })
                .css({
                    'position': 'absolute',
                    'height': '300px',
                    'width': '300px',
                    'z-index': '100'
                })
                .appendTo($('body'))
                .animate({
                    'top': cart.offset().top + 10,
                    'left': cart.offset().left + 10,
                    'width': 25,
                    'height': 25
                }, 2000, 'easeInBounce', function () {
                    $(".img-overlay").show();
                });

        setTimeout(function () {
            cart.effect("shake", {
                times: 2
            }, 200);
        }, 1500);

        imgclone.animate({
            'width': 0,
            'height': 0
        }, function () {
            $(this).detach()
        });
    }
    return false;

}


function disable_remove() { $("#cache_cart").attr("disabled", "disabled"); $("#cache_cart").removeAttr("href"); $(".item-in-cart .icon-remove-sign").remove(); }
function InvalidMsg(textbox, patternmsg, requiredmsg) {

    if (textbox.validity.patternMismatch) {
        textbox.setCustomValidity(patternmsg);
    }
    else {
        textbox.setCustomValidity(requiredmsg);
    }
    return true;
}


function city_selected(ostan_id, city) {
    var Indx = ostan_id;
    with (document.getElementById('city_id')) {
        options.length = 0;
        if (Indx == 0) {
            options[0] = new Option("لطفا استان خود را انتخاب کنيد", "");
        }
        if (Indx == 26) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("آسارا", "1");
            options[2] = new Option("اشتهارد", "2");
            options[3] = new Option("چهار باغ", "3");
            options[4] = new Option("صفادشت", "4");
            options[5] = new Option("طالقان", "5");
            options[6] = new Option("کرج", "6");
            options[6].className = "new_ostan"
            options[7] = new Option("کوهسار", "7");
            options[8] = new Option("نظر آباد", "8");
            options[9] = new Option("هشتگرد", "9");
        }
        if (Indx == 41) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("آذر شهر", "1");
            options[2] = new Option("اسكو", "2");
            options[3] = new Option("اهر", "3");
            options[4] = new Option("بستان آباد", "4");
            options[5] = new Option("بناب", "5");
            options[6] = new Option("بندر شرفخانه", "6");
            options[7] = new Option("تبريز", "7");
            options[7].className = "new_ostan"
            options[8] = new Option("تسوج", "8");
            options[9] = new Option("جلفا", "9");
            options[10] = new Option("سراب", "10");
            options[11] = new Option("شبستر", "11");
            options[12] = new Option("صوفیان", "12");
            options[13] = new Option("عجبشير", "13");
            options[14] = new Option("قره آغاج", "14");
            options[15] = new Option("كليبر", "15");
            options[16] = new Option("كندوان", "16");
            options[17] = new Option("مراغه", "17");
            options[18] = new Option("مرند", "18");
            options[19] = new Option("ملكان", "19");
            options[20] = new Option("ميانه", "20");
            options[21] = new Option("ورزقان", "21");
            options[22] = new Option("هاديشهر", "22");
            options[23] = new Option("هريس", "23");
            options[24] = new Option("هشترود", "24");
            options[25] = new Option("ممقان", "25");
        }
        if (Indx == 44) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("اروميه", "1");
            options[1].className = "new_ostan"
            options[2] = new Option("اشنويه", "2");
            options[3] = new Option("بازرگان", "3");
            options[4] = new Option("بوكان", "4");
            options[5] = new Option("پيرانشهر", "5");
            options[6] = new Option("تكاب", "6");
            options[7] = new Option("چالدران", "7");
            options[8] = new Option("خوي", "8");
            options[9] = new Option("سر دشت", "9");
            options[10] = new Option("سلماس", "10");
            options[11] = new Option("سيه چشمه", "11");
            options[12] = new Option("شاهين دژ", "12");
            options[13] = new Option("ماكو", "13");
            options[14] = new Option("مهاباد", "14");
            options[15] = new Option("مياندوآب", "15");
            options[16] = new Option("نقده", "16");
        }
        if (Indx == 45) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("اردبيل", "1");
            options[1].className = "new_ostan"
            options[2] = new Option("بيله سوار", "2");
            options[3] = new Option("پارس آباد", "3");
            options[4] = new Option("خلخال", "4");
            options[5] = new Option("سرعين", "5");
            options[6] = new Option("گیوی(کوثر)", "6");
            options[7] = new Option("گرمي", "7");
            options[8] = new Option("مشگين شهر", "8");
            options[9] = new Option("نمين", "9");
            options[10] = new Option("نير", "10");
        }
        if (Indx == 31) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("آران و بيدگل", "1");
            options[2] = new Option("اردستان", "2");
            options[3] = new Option("اصفهان", "3");
            options[3].className = "new_ostan"
            options[4] = new Option("باغ بهادران", "4");
            options[5] = new Option("تيران", "5");
            options[6] = new Option("چادگان", "6");
            options[7] = new Option("خميني شهر", "7");
            options[8] = new Option("خوانسار", "8");
            options[9] = new Option("دولت آباد", "9");
            options[10] = new Option("دهاقان", "10");
            options[11] = new Option("زرين شهر", "11");
            options[12] = new Option("زیبا شهر", "12");
            options[13] = new Option("سميرم", "13");
            options[14] = new Option("سپاهان شهر", "14");
            options[15] = new Option("شاهين شهر", "15");
            options[16] = new Option("شهرضا", "16");
            options[17] = new Option("فريدن", "17");
            options[18] = new Option("فريدون شهر", "18");
            options[19] = new Option("فلاورجان", "19");
            options[20] = new Option("فولاد شهر", "20");
            options[21] = new Option("قهدریجان", "21");
            options[22] = new Option("كاشان", "22");
            options[23] = new Option("گلدشت", "23");
            options[24] = new Option("گلپايگان", "24");
            options[25] = new Option("مباركه", "25");
            options[26] = new Option("ملک شهر", "26");
            options[27] = new Option("نايين", "27");
            options[28] = new Option("نجف آباد", "28");
            options[29] = new Option("نطنز", "29");
            options[30] = new Option("هرند", "30");
        }
        if (Indx == 84) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("آبدانان", "1");
            options[2] = new Option("ايلام", "2");
            options[2].className = "new_ostan"
            options[3] = new Option("ايوان", "3");
            options[4] = new Option("دره شهر", "4");
            options[5] = new Option("دهلران", "5");
            options[6] = new Option("سرابله", "6");
            options[7] = new Option("مهران", "7");
        }
        if (Indx == 77) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("اهرم", "1");
            options[2] = new Option("برازجان", "2");
            options[3] = new Option("آبپخش", "3");
            options[4] = new Option("بوشهر", "4");
            options[4].className = "new_ostan"
            options[5] = new Option("تنگستان", "5");
            options[6] = new Option("جم", "6");
            options[7] = new Option("خارك", "7");
            options[8] = new Option("خورموج", "8");
            options[9] = new Option("دشتستان", "9");
            options[10] = new Option("دشتي", "10");
            options[11] = new Option("دلوار", "11");
            options[12] = new Option("دير", "12");
            options[13] = new Option("ديلم", "13");
            options[14] = new Option("عسلویه", "14");
            options[15] = new Option("كنگان", "15");
            options[16] = new Option("گناوه", "16");
        }
        if (Indx == 21) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("اسلامشهر", "1");
            options[2] = new Option("اندیشه", "2");
            options[3] = new Option("بومهن", "3");
            options[4] = new Option("پاكدشت", "4");
            options[5] = new Option("تجريش", "5");
            options[6] = new Option("تهران", "6");
            options[6].className = "new_ostan"
            options[7] = new Option("چهاردانگه", "7");
            options[8] = new Option("دماوند", "8");
            options[9] = new Option("رباط كريم", "9");
            options[10] = new Option("رودهن", "10");
            options[11] = new Option("ري", "11");
            options[12] = new Option("شريف آباد", "12");
            options[13] = new Option("شهريار", "13");
            options[14] = new Option("فشم", "14");
            options[15] = new Option("فيروزكوه", "15");
            options[16] = new Option("قدس", "16");
            options[17] = new Option("قرچك", "17");
            options[18] = new Option("كن", "18");
            options[19] = new Option("كهريزك", "19");
            options[20] = new Option("گلستان", "20");
            options[21] = new Option("لواسان", "21");
            options[22] = new Option("ملارد", "22");
            options[23] = new Option("ورامين", "23");
        }
        if (Indx == 38) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("اردل", "1");
            options[2] = new Option("بروجن", "2");
            options[3] = new Option("چلگرد", "3");
            options[4] = new Option("سامان", "4");
            options[5] = new Option("شهركرد", "5");
            options[5].className = "new_ostan"
            options[6] = new Option("فارسان", "6");
            options[7] = new Option("فرخ شهر", "7");
            options[8] = new Option("لردگان", "8");
            options[9] = new Option("هفشجان", "9");
        }
        if (Indx == 56) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("بشرویه", "1");
            options[2] = new Option("بيرجند", "2");
            options[2].className = "new_ostan"
            options[3] = new Option("خضری", "3");
            options[4] = new Option("سرایان", "4");
            options[5] = new Option("سربيشه", "5");
            options[6] = new Option("فردوس", "6");
            options[7] = new Option("قائن", "7");
            options[8] = new Option("نهبندان", "8");
        }
        if (Indx == 51) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("بردسكن", "1");
            options[2] = new Option("بجستان", "2");
            options[3] = new Option("تايباد", "3");
            options[4] = new Option("تربت جام", "4");
            options[5] = new Option("تربت حيدريه", "5");
            options[6] = new Option("جغتای", "6");
            options[7] = new Option("جوین", "7");
            options[8] = new Option("چناران", "8");
            options[9] = new Option("خواف", "9");
            options[10] = new Option("خلیل آباد", "10");
            options[11] = new Option("درگز", "11");
            options[12] = new Option("رشتخوار", "12");
            options[13] = new Option("سبزوار", "13");
            options[14] = new Option("سرخس", "14");
            options[15] = new Option("طوس", "15");
            options[16] = new Option("طرقبه", "16");
            options[17] = new Option("فريمان", "17");
            options[18] = new Option("قوچان", "18");
            options[19] = new Option("كاشمر", "19");
            options[20] = new Option("كلات", "20");
            options[21] = new Option("گناباد", "21");
            options[22] = new Option("مشهد", "22");
            options[22].className = "new_ostan"
            options[23] = new Option("نيشابور", "23");
        }
        if (Indx == 58) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("آشخانه", "1");
            options[2] = new Option("اسفراين", "2");
            options[3] = new Option("بجنورد", "3");
            options[3].className = "new_ostan"
            options[4] = new Option("جاجرم", "4");
            options[5] = new Option("شيروان", "5");
            options[6] = new Option("فاروج", "6");
        }
        if (Indx == 61) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("آبادان", "1");
            options[2] = new Option("اميديه", "2");
            options[3] = new Option("انديمشك", "3");
            options[4] = new Option("اهواز", "4");
            options[4].className = "new_ostan"
            options[5] = new Option("ايذه", "5");
            options[6] = new Option("گتوند", "6");
            options[7] = new Option("باغ ملك", "7");
            options[8] = new Option("بندرامام خميني", "8");
            options[9] = new Option("بندر ماهشهر", "9");
            options[10] = new Option("بهبهان", "10");
            options[11] = new Option("خرمشهر", "11");
            options[12] = new Option("دزفول", "12");
            options[13] = new Option("رامهرمز", "13");
            options[14] = new Option("رامشیر", "14");
            options[15] = new Option("سوسنگرد", "15");
            options[16] = new Option("شادگان", "16");
            options[17] = new Option("شوشتر", "17");
            options[18] = new Option("شوش", "18");
            options[19] = new Option("لالي", "19");
            options[20] = new Option("مسجد سليمان", "20");
            options[21] = new Option("هنديجان", "21");
            options[22] = new Option("هويزه", "22");
        }
        if (Indx == 24) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("آب بر", "1");
            options[2] = new Option("ابهر", "2");
            options[3] = new Option("ايجرود", "3");
            options[4] = new Option("خرمدره", "4");
            options[5] = new Option("زرين آباد", "5");
            options[6] = new Option("زنجان", "6");
            options[6].className = "new_ostan"
            options[7] = new Option("قيدار", "7");
            options[8] = new Option("ماهنشان", "8");
        }
        if (Indx == 23) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("ايوانكي", "1");
            options[2] = new Option("بسطام", "2");
            options[3] = new Option("دامغان", "3");
            options[4] = new Option("سمنان", "4");
            options[5] = new Option("سرخه", "5");
            options[6] = new Option("شاهرود", "6");
            options[7] = new Option("شهمیرزاد", "7");
            options[8] = new Option("گرمسار", "8");
            options[9] = new Option("مهدیشهر", "9");
        }
        if (Indx == 54) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("ايرانشهر", "1");
            options[2] = new Option("چابهار", "2");
            options[3] = new Option("خاش", "3");
            options[4] = new Option("راسك", "4");
            options[5] = new Option("زابل", "5");
            options[6] = new Option("زاهدان", "6");
            options[6].className = "new_ostan"
            options[7] = new Option("سراوان", "7");
            options[8] = new Option("سرباز", "8");
            options[9] = new Option("فنوج", "9");
            options[10] = new Option("کنارک", "10");
            options[11] = new Option("ميرجاوه", "11");
            options[12] = new Option("نيكشهر", "12");
        }
        if (Indx == 71) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("آباده", "1");
            options[2] = new Option("اردكان", "2");
            options[3] = new Option("ارسنجان", "3");
            options[4] = new Option("استهبان", "4");
            options[5] = new Option("اقليد", "5");
            options[6] = new Option("ایزد خواست", "6");
            options[7] = new Option("بوانات", "7");
            options[8] = new Option("پاسارگاد", "8");
            options[9] = new Option("جهرم", "9");
            options[10] = new Option("حاجي آباد", "10");
            options[11] = new Option("خرم بید", "11");
            options[12] = new Option("خنج", "12");
            options[13] = new Option("خشت", "13");
            options[14] = new Option("داراب", "14");
            options[15] = new Option("شيراز", "15");
            options[15].className = "new_ostan"
            options[16] = new Option("فراشبند", "16");
            options[17] = new Option("فسا", "17");
            options[18] = new Option("فيروز آباد", "18");
            options[19] = new Option("قایمیه", "19");
            options[20] = new Option("قيرو کارزین", "20");
            options[21] = new Option("كازرون", "21");
            options[22] = new Option("گراش", "22");
            options[23] = new Option("لار", "23");
            options[24] = new Option("لامرد", "24");
            options[25] = new Option("مرودشت", "25");
            options[26] = new Option("مصیری(رستم)", "26");
            options[27] = new Option("مهر", "27");
            options[28] = new Option("نورآباد", "28");
            options[29] = new Option("ني ريز", "29");
        }
        if (Indx == 28) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("آبيك", "1");
            options[2] = new Option("شهرک البرز", "2");
            options[3] = new Option("بوئين زهرا", "3");
            options[4] = new Option("تاكستان", "4");
            options[5] = new Option("قزوين", "5");
            options[6] = new Option("محمود آباد نمونه", "6");
        }
        if (Indx == 25) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("قم", "1");
        }
        if (Indx == 87) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("بانه", "1");
            options[2] = new Option("بيجار", "2");
            options[3] = new Option("ديواندره", "3");
            options[4] = new Option("دهگلان", "4");
            options[5] = new Option("سقز", "5");
            options[6] = new Option("سنندج", "6");
            options[7] = new Option("قروه", "7");
            options[8] = new Option("كامياران", "8");
            options[9] = new Option("مريوان", "9");
        }
        if (Indx == 34) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("شهر بابك", "1");
            options[2] = new Option("بافت", "2");
            options[3] = new Option("بردسير", "3");
            options[4] = new Option("بم", "4");
            options[5] = new Option("جيرفت", "5");
            options[6] = new Option("سرچشمه", "6");
            options[7] = new Option("راور", "7");
            options[8] = new Option("رفسنجان", "8");
            options[9] = new Option("زرند", "9");
            options[10] = new Option("سيرجان", "10");
            options[11] = new Option("كرمان", "11");
            options[12] = new Option("كهنوج", "12");
        }
        if (Indx == 83) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("اسلام آباد غرب", "1");
            options[2] = new Option("پاوه", "2");
            options[3] = new Option("ثلاث باباجانی", "3");
            options[4] = new Option("جوانرود", "4");
            options[5] = new Option("خسروی", "5");
            options[6] = new Option("سر پل ذهاب", "6");
            options[7] = new Option("سنقر", "7");
            options[8] = new Option("صحنه", "8");
            options[9] = new Option("قصر شيرين", "9");
            options[10] = new Option("كرمانشاه", "10");
            options[11] = new Option("كنگاور", "11");
            options[12] = new Option("گيلان غرب", "12");
            options[13] = new Option("هرسين", "13");
        }
        if (Indx == 74) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("دنا", "1");
            options[2] = new Option("دوگنبدان", "2");
            options[3] = new Option("دهدشت", "3");
            options[4] = new Option("سي سخت", "4");
            options[5] = new Option("گچساران", "5");
            options[6] = new Option("لیکک", "6");
            options[7] = new Option("ياسوج", "7");
            options[7].className = "new_ostan"
        }
        if (Indx == 17) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("آزاد شهر", "1");
            options[2] = new Option("آق قلا", "2");
            options[3] = new Option("بندر گز", "3");
            options[4] = new Option("تركمن", "4");
            options[5] = new Option("جلین", "5");
            options[6] = new Option("راميان", "6");
            options[7] = new Option("علي آباد كتول", "7");
            options[8] = new Option("كردكوي", "8");
            options[9] = new Option("كلاله", "9");
            options[10] = new Option("گالیکش", "10");
            options[11] = new Option("گرگان", "11");
            options[11].className = "new_ostan"
            options[12] = new Option("گنبد كاووس", "12");
            options[13] = new Option("مراوه تپه", "13");
            options[14] = new Option("مينو دشت", "14");
        }
        if (Indx == 13) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("آستارا", "1");
            options[2] = new Option("آستانه اشرفيه", "2");
            options[3] = new Option("املش", "3");
            options[4] = new Option("بندرانزلي", "4");
            options[5] = new Option("تالش", "5");
            options[6] = new Option("خمام", "6");
            options[7] = new Option("رودبار", "7");
            options[8] = new Option("رود سر", "8");
            options[9] = new Option("رستم آباد", "9");
            options[10] = new Option("رشت", "10");
            options[10].className = "new_ostan"
            options[11] = new Option("رضوان شهر", "11");
            options[12] = new Option("سياهكل", "12");
            options[13] = new Option("شفت", "3");
            options[14] = new Option("صومعه سرا", "14");
            options[15] = new Option("فومن", "15");
            options[16] = new Option("كلاچاي", "16");
            options[17] = new Option("لاهيجان", "17");
            options[18] = new Option("لنگرود", "18");
            options[19] = new Option("لوشان", "19");
            options[20] = new Option("ماسال", "20");
            options[21] = new Option("ماسوله", "21");
            options[22] = new Option("منجيل", "22");
        }
        if (Indx == 66) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("ازنا", "1");
            options[2] = new Option("الشتر", "2");
            options[3] = new Option("اليگودرز", "3");
            options[4] = new Option("بروجرد", "4");
            options[5] = new Option("پلدختر", "5");
            options[6] = new Option("خرم آباد", "6");
            options[7] = new Option("دورود", "7");
            options[8] = new Option("سراب دوره", "8");
            options[9] = new Option("سپید دشت", "9");
            options[10] = new Option("شول آباد", "10");
            options[11] = new Option("كوهدشت", "11");
            options[12] = new Option("نور آباد", "12");
        }
        if (Indx == 15) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("آمل", "1");
            options[2] = new Option("بلده", "2");
            options[3] = new Option("بهشهر", "3");
            options[4] = new Option("بابل", "4");
            options[5] = new Option("بابلسر", "5");
            options[6] = new Option("پل سفيد", "6");
            options[7] = new Option("تنكابن", "7");
            options[8] = new Option("جويبار", "8");
            options[9] = new Option("چالوس", "9");
            options[10] = new Option("رامسر", "10");
            options[11] = new Option("ساري", "11");
            options[11].className = "new_ostan"
            options[12] = new Option("سلمانشهر", "12");
            options[13] = new Option("سواد كوه", "13");
            options[14] = new Option("فريدون كنار", "14");
            options[15] = new Option("کلاردشت", "15");
            options[16] = new Option("قائم شهر", "16");
            options[17] = new Option("گلوگاه", "17");
            options[18] = new Option("محمود آباد", "18");
            options[19] = new Option("مرزن آباد", "19");
            options[20] = new Option("نكا", "20");
            options[21] = new Option("نور", "21");
            options[22] = new Option("نوشهر", "22");
        }
        if (Indx == 86) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("آشتيان", "1");
            options[2] = new Option("اراك", "2");
            options[2].className = "new_ostan"
            options[3] = new Option("تفرش", "3");
            options[4] = new Option("خمين", "4");
            options[5] = new Option("خنداب", "5");
            options[6] = new Option("دليجان", "6");
            options[7] = new Option("زرندیه", "7");
            options[8] = new Option("ساوه", "8");
            options[9] = new Option("شازند", "9");
            options[10] = new Option("کمیجان", "10");
            options[11] = new Option("محلات", "11");
        }
        if (Indx == 76) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("ابوموسي", "1");
            options[2] = new Option("انگهران", "2");
            options[3] = new Option("بندر جاسك", "3");
            options[4] = new Option("بندر خمیر", "4");
            options[5] = new Option("بندرعباس", "5");
            options[5].className = "new_ostan"
            options[6] = new Option("بندر لنگه", "6");
            options[7] = new Option("بستك", "7");
            options[8] = new Option("پارسیان", "8");
            options[9] = new Option("تنب بزرگ", "9");
            options[10] = new Option("حاجي آباد", "10");
            options[11] = new Option("دهبارز", "11");
            options[12] = new Option("قشم", "12");
            options[13] = new Option("كيش", "13");
            options[14] = new Option("ميناب", "14");
        }
        if (Indx == 81) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("اسدآباد", "1");
            options[2] = new Option("بهار", "2");
            options[3] = new Option("تويسركان", "3");
            options[4] = new Option("رزن", "4");
            options[5] = new Option("كبودر اهنگ", "5");
            options[6] = new Option("ملاير", "6");
            options[7] = new Option("نهاوند", "7");
            options[8] = new Option("همدان", "8");
            options[8].className = "new_ostan"
        }
        if (Indx == 35) {
            options[0] = new Option("لطفا شهر خود را انتخاب کنيد", "");
            options[1] = new Option("ابركوه", "1");
            options[2] = new Option("اردكان", "2");
            options[3] = new Option("اشكذر", "3");
            options[4] = new Option("بافق", "4");
            options[5] = new Option("تفت", "5");
            options[6] = new Option("طبس", "6");
            options[7] = new Option("مهريز", "7");
            options[8] = new Option("ميبد", "8");
            options[9] = new Option("هرات", "9");
            options[10] = new Option("يزد", "10");
            options[10].className = "new_ostan"
        }
        if (city != null) {
            document.getElementById('city_id').options[parseInt(city.toString())].selected = true;
        }
        else
            document.getElementById('city_id').options[1].selected = true;
    }
}