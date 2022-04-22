let btn = document.querySelectorAll(".num");
        let input = document.querySelector("input");
        let btnclean = document.getElementById("X");
        let btncheck = document.getElementById("V");
        let min = 0;
        let max = 100;
        let anser;
        let btnreset = document.getElementById("replay");

        window.onload = function () {
            replay();
            show();
        }

        function replay() {
            min = 0;
            max = 100;
            anser = Math.floor(Math.random() * 99) + 1;
            show();

        }

        for (var i of btn) {
            i.value = i.innerHTML;
            i.addEventListener("click", function (event) {
                input.value += event.target.value;
            });
        }
        btnreset.addEventListener("click", function (event) {
            replay();
        })
        btnclean.addEventListener("click", function (event) {
            input.value = "";
        })
        btncheck.addEventListener("click", function (event) {
            check();
        })
        function check() {

            enterAns = parseInt(input.value);
            if (enterAns < min || enterAns > max) {
                alert(`請輸入${min}~${max}的值`);
            }
            else if (enterAns > anser) {
                max = enterAns;
                show();
            }
            else if (enterAns < anser) {
                min = enterAns;
                show();
            }
            else if (enterAns = anser) {
                alert(`答案為${anser}，恭喜答對`);
                replay();
            }

        }

        function show() {
            display = document.getElementById("h2");
            display.innerHTML = min + "~" + max;
            input.value = "";
        }