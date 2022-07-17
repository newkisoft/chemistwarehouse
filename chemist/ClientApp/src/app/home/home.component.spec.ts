// app.component.spec.ts
import { HttpClientModule } from '@angular/common/http';
import { TestBed, waitForAsync } from '@angular/core/testing'; // 1
import { ProductService } from '../services/ProductService';
import { HomeComponent } from './home.component';
 
describe('HomeComponent', () => { // 2
  beforeEach(waitForAsync(() => { // 3
    TestBed.configureTestingModule({
      imports: [HttpClientModule],
      declarations: [
        HomeComponent
      ],      
      providers: [ProductService],
    }).compileComponents();
  }));
 
  it('should create the home component', () => { // 4
    const fixture = TestBed.createComponent(HomeComponent);
    const home = fixture.debugElement.componentInstance;
    expect(home).toBeTruthy();
  });
 
  it(`should have as title 'angular-component-testing'`, () => {  //5
    const fixture = TestBed.createComponent(HomeComponent);
    const home = fixture.debugElement.componentInstance;
    expect(home.products.length).toEqual(0);
  });
 
  it('should render title in a h1 tag', () => { //6
    const fixture = TestBed.createComponent(HomeComponent);
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    expect(compiled.querySelector('#AddButton').textContent).toContain('Add');
  });
});