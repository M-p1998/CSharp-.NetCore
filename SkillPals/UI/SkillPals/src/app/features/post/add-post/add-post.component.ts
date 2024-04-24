import { Component, OnDestroy } from '@angular/core';
import { AddPostRequest } from '../models/add-post-request.model';
import { PostService } from '../services/post.service';
import { Subscription } from 'rxjs';
import { Router } from '@angular/router';


@Component({
  selector: 'app-add-post',
  templateUrl: './add-post.component.html',
  styleUrl: './add-post.component.css'
})
export class AddPostComponent implements OnDestroy{

  model: AddPostRequest;
  // ? means unsubscription type or undefined
  private addPostSubscription?: Subscription;
  constructor(private postService : PostService,
    private router: Router){
    this.model = {
      title: "",
      picture: "",
      description: "",
      creator: ""
    };
  }

  onFormSubmit(){
    this.addPostSubscription = this.postService.addPost(this.model)
    .subscribe({
      next: (response) => {
        // console.log("This was successful")
        this.router.navigateByUrl("/posts")
      }
      // error: (error)=> {

      // }
    });
  }

  ngOnDestroy(): void {
    this.addPostSubscription?.unsubscribe();
  }
}
