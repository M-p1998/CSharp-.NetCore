using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SkillPals.API.Models.DTO;
using SkillPals.API.Models.Domain;
using Microsoft.AspNetCore.Http.HttpResults;
using SkillPals.API.Data;
using SkillPals.API.Repositories.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SkillPals.API.Controllers
{
//https://localhost:xxxx/api/post
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : Controller
    {
        private readonly IPostRepository pRepo;
        public PostController(IPostRepository postRepo)
        {
            pRepo = postRepo;
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> CreatePost(CreatePostRequestDto request)
        {
            //Map DTO to domain model
            var post = new Post
            {
                Title = request.Title,
                Picture = request.Picture,
                Description = request.Description,
                Creator = request.Creator,
                //PublishedDate = request.PublishedDate
            };

            await pRepo.CreateAsync(post);

            //Domain  model to DTO
            var response = new PostDto
            {
                Id = post.Id,
                Title = post.Title,
                Picture = post.Picture,
                Description = post.Description,
                Creator = post.Creator,
                PublishedDate = post.PublishedDate
            };

            return Ok(response);

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

