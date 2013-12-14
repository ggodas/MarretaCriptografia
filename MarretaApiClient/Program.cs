using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MarretaApiClient
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TextInfo myTI = new CultureInfo("pt-BR",false).TextInfo;
            var nom = myTI.ToTitleCase("george krajan godas");

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:18104/");
            //client.BaseAddress = new Uri("http://casaart.com.br/mobilewebapi/");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));


            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "Z2dvZGFzQGdtYWlsLmNvbTpqdWwxNEowZDRyIQ==");
            Uri gizmoUri = null;
            var postViewModel = new PostViewModel{
                User = "ggodas@gmail.com",
                DeviceModel = "1900",
                DeviceName = "54564"

            };

            var encriptado = Criptografia.Encrypt(System.Text.Encoding.ASCII.GetBytes(@"{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}


  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}{
  user:'ggodas@gmail.com',
  deviceModel:'1900',
  deviceName:'UmAndroid',
  OS:'AndroideTambem',
  uid:'4654544654654',
  mobileCountryCode:'55',
  carrierName:'10',
  isoCountryCode:'545',
  mobileNetworkCode:'456465'
   
}
FIM
"), "jul14J0d4r!");


            HttpContent content = new ByteArrayContent(encriptado);

            var response = client.PostAsync("api/device/initialize", content);


            var myobject = response.Result.Content.ReadAsByteArrayAsync().Result;//.ReadAsAsync<PostResultViewModel>();

            var conteudo = Encoding.ASCII.GetString(myobject);
        }
    }

    public class PostViewModel
    {
        public string User { get; set; }
        public string DeviceModel { get; set; }
        public string DeviceName { get; set; }
        public string OS { get; set; }
        public string Uid { get; set; }
        public string MobileCountryCode { get; set; }
        public string CarrierName { get; set; }
        public string IsoCountryCode { get; set; }
        public string MobileNetworkCode { get; set; }
    
    }


    public class PostResultViewModel
    {
        public string CustomerType { get; set; }
        public string CustomerName { get; set; }
        public string[] Messages { get; set; }
        public string Credential { get; set; }
        public string Enabled { get; set; }
        public string Hash { get; set; }
        public byte[] Salt { get; set; }
        public byte[] Vector { get; set; }
    }
}
