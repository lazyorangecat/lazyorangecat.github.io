let Cars=['BMW','Benz','Audi','Lexus'];

var car = Cars.find(c=>c=='Benz');
console.group(car)

var car = Cars.find(c=>c=='Toyota');//undefined
console.group(car);

var index=Cars.indexOf('Audi');
console.log(index);

var index=Cars.indexOf('Toyota');
console.log(index);

let Prices=[280,30,250,210];
console.log(Prices.findIndex(p=>p>200));

console.log(Prices.filter(p=>p>250));
console.log(Prices.filter(p=>p>250&& p<=300));

Prices.filter(function(item,index){
    if(item>250){
        console.log(Cars[index]+"的價格是:"+item+",價錢大於250萬")
    }
});

