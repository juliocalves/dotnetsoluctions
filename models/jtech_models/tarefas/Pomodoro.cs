using System;
using System.ComponentModel.DataAnnotations;

namespace jtech_models.tarefas
{
    /// <summary>
    /// Representa um Pomodoro, uma técnica de gerenciamento de tempo.
    /// </summary>
    public class Pomodoro
    {
        /// <summary>
        /// Identificador único do Pomodoro.
        /// </summary>
        [Key]
        public int PomoId { get; set; }

        /// <summary>
        /// Tarefa associada ao Pomodoro.
        /// </summary>
        public SubTarefa? PomoTarefa { get; set; }

        /// <summary>
        /// Subtarefa associada ao Pomodoro.
        /// </summary>
        public SubTarefa? PomoSubTarefa { get; set; }

        /// <summary>
        /// Contagem atual do Pomodoro.
        /// </summary>
        public int PomoContagem { get; set; }

        /// <summary>
        /// Meta do Pomodoro.
        /// </summary>
        public int PomoMeta { get; set; }

        /// <summary>
        /// Data e hora de início do Pomodoro.
        /// </summary>
        public DateTime PomoInicio { get; set; }

        /// <summary>
        /// Data e hora de término do Pomodoro.
        /// </summary>
        public DateTime PomoFim { get; set; }

        /// <summary>
        /// Indica se o Pomodoro foi concluído.
        /// </summary>
        public bool PomoConcluido { get; set; }
    }
}
