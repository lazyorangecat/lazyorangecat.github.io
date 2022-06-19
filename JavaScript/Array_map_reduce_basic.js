let Price=[100,200,300];

//傳統寫法
let priceArray=[];
Price.forEach((p)=> {
    priceArray.push(p*1.05);
});
console.log(priceArray);

//map()
let PriceTax= Price.map(x=>x*1.05);

let PriceWithTax=Price.map(function(p){
    p=p*1.05;
    p=p/29;
    return p 
});

console.log(PriceWithTax)

//傳統寫法
let Total=0;
Price.forEach((p)=> {
    Total=Total+p;
});
console.log(Total);