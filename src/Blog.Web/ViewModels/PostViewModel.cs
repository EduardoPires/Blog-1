using System;
using System.ComponentModel.DataAnnotations;
using Blog.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace Blog.Web.ViewModels;

public class PostViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "A descrição é obrigatória")]
    public string Descricao { get; set; }
    public string AutorId { get; set; }
    public IdentityUser Autor { get; set; }
    [Required(ErrorMessage = "O título é obrigatório")]
    public string Titulo { get; set; }
    public DateTime DataPublicacao { get; set; }
    public ICollection<Comentario> Comentarios { get; set; }

}
