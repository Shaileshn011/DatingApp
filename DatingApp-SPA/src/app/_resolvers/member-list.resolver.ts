import { Injectable } from '@angular/core';
import { Resolve, Router, ActivatedRouteSnapshot } from '@angular/router';
import {User} from '../_models/user';
import { from, Observable, of } from 'rxjs';
import { UserService } from '../_services/user.service';
import { AlertifyService } from '../_services/alertify.service';
import { catchError } from 'rxjs/operators';
@Injectable()

export class MemberListResolver implements Resolve<User[]> {
    constructor(private userService: UserService, private router: Router, private alertify: AlertifyService) {}

    resolve(rout: ActivatedRouteSnapshot): Observable<User[]> {
        return this.userService.getUsers().pipe(
            catchError(error => {
              this.alertify.error(error);
              this.router.navigate(['/home']);
              return of(null);
            })
        );
    }
}
