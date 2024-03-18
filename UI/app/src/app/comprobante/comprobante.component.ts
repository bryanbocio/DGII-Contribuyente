import { Component, OnInit } from '@angular/core';
import { ComprobanteService } from './comprobante.service';
import { IComprobanteFiscal } from '../shared/models/comprobante.type';
import { ActivatedRoute } from '@angular/router';
import { ComprobanteParams } from '../shared/models/comprobante.params';

@Component({
  selector: 'app-comprobante',
  templateUrl: './comprobante.component.html',
  styleUrls: ['./comprobante.component.scss']
})
export class ComprobanteComponent implements OnInit{

    public comprobantes:IComprobanteFiscal[]=[]
    public isReady=false;
    comprobanteParams=new ComprobanteParams();
    constructor(private servicio:ComprobanteService, private route:ActivatedRoute){
      
    }
  ngOnInit(): void {
   if(this.comprobantes.length ==0){
    this.cargarDatos();
   }
  }
  cargarDatos(){
    const contribuyenteId=this.route.snapshot.paramMap.get('id');
    if(contribuyenteId){
      this.comprobanteParams.contribuyenteId=+contribuyenteId;
      if(contribuyenteId.toString() !=='todos'){
        this.isReady=true
      }else{
        this.isReady=false
      }
    }
    
    this.servicio.getComprobantes(this.comprobanteParams).subscribe({
      next:response=>{
        this.comprobantes=response.data;
      }
    })

    
  }

   public getTotalItbis(){
    let Itbis=0
    this.comprobantes.forEach(comprobante=>{
      Itbis=Itbis + comprobante.itbis
     })

     return Itbis;
  }



    
}
