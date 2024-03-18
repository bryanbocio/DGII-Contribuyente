import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ContribuyenteComponent } from './contribuyente/contribuyente.component';
import { HttpClientModule } from '@angular/common/http';
import { NavBarComponent } from './core/nav-bar/nav-bar.component';
import { CoreModule } from './core/core.module';
import { ComprobanteComponent } from './comprobante/comprobante.component';

@NgModule({
  declarations: [
    AppComponent,
    ContribuyenteComponent,
    ComprobanteComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    CoreModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
