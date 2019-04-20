import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { $ } from 'jquery';

import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { HeroComponent } from './components/hero/hero.component';
import { DropDownDirective } from './components/navmenu/DropDownDirective'

export const sharedConfig: NgModule = {
	bootstrap: [AppComponent],
	declarations: [
		AppComponent,
		NavMenuComponent,
		CounterComponent,
		FetchDataComponent,
		HomeComponent,
		HeroComponent,
		DropDownDirective
	],
	imports: [
		RouterModule.forRoot([
			{ path: '', redirectTo: 'home', pathMatch: 'full' },
			{ path: 'home', component: HomeComponent },
			{ path: 'hero', component: HeroComponent },
			{ path: 'counter', component: CounterComponent },
			{ path: 'fetch-data', component: FetchDataComponent },
			{ path: '**', redirectTo: 'home' }
		])
	]
};