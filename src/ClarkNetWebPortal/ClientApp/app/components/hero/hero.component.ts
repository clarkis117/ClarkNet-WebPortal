import { Component } from '@angular/core';

@Component({
	selector: 'hero',
   template:`<h1> {{title }}</h1>
	<h2> {{hero.name }} details! </h2>
	<div> <label>id: </label>{{hero.id}}</div>
	<div>
	<label>name: </label>
	<input value= "{{hero.name}}" placeholder= "name" >
	</div>`
})
export class HeroComponent {
	title = "hero";
	hero: Hero = {
		id: 1,
		name: "hero1"
	};
}

export class Hero {
	id: number;
	name: string;
}