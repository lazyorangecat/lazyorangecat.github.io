const promise1=new Promise(function (resolve,reject){
    setTimeout(()=>{
        resolve("成功的話，會呼叫resolve方法")
        reject("失敗的話，會呼叫reject方法")
        },3000)
})
promise1
    .then(result=>{
        console.log("成功的回傳值")
    })