import HttpService from "./HttpService"

const naziv='/Smjer'
async function get(){
    return await HttpService.get(naziv)
    .then((odgovor)=>{
        console.log(odgovor);
    })
    .catch((e)=>{
        console.log(e);
    })
}

export default{
    get
}