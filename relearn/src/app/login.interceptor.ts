import { tap } from 'rxjs/operators';
import { HttpEvent, HttpEventType, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import {Observable} from 'rxjs';
export class LoginInterceptor implements HttpInterceptor{
    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        return next.handle(req).pipe(
          tap((event) => {
            if (event.type == HttpEventType.Response) {
              console.log(event.type);
              console.log("incoming request");
            }
          })
        );    
    }

}