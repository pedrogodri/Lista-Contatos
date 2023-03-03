import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { ListContactsComponent } from './components/list-contacts/list-contacts.component';
import { AddContactComponent } from './components/add-contact/add-contact.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ListContactsComponent,
    AddContactComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
